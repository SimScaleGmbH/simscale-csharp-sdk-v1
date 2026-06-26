using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

[JsonConverter(typeof(UiConfigurationEntryConverter))]
public interface UiConfigurationEntry { }

internal class UiConfigurationEntryConverter : JsonConverter<UiConfigurationEntry>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["builtin:navigation"] = typeof(NavigationUiConfigurationEntry),
        ["builtin:navigation:list"] = typeof(NavigationListUiConfigurationEntry),
        ["builtin:plot"] = typeof(Plot2DUiConfigurationEntry),
        ["builtin:slider"] = typeof(SliderUiConfigurationEntry),
        ["builtin:title"] = typeof(CompoundFieldTitleUiConfigurationEntry),
        ["builtin:visibility"] = typeof(VisibilityUiConfigurationEntry),
        ["custom"] = typeof(CompoundFieldCustomUiConfigurationEntry),
        ["unknown"] = typeof(UnknownUiConfigurationEntry),
    };

    public override UiConfigurationEntry? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("configuration_entry_type", out var discProp))
            throw new JsonException("Missing discriminator property \"configuration_entry_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"configuration_entry_type\"");
        return ((UiConfigurationEntry?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, UiConfigurationEntry value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
