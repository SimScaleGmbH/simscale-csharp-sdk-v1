using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

[JsonConverter(typeof(StateMetadataConverter))]
public interface StateMetadata { }

internal class StateMetadataConverter : JsonConverter<StateMetadata>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DEFAULT"] = typeof(DefaultStateMetadata),
        ["AUTOMATIC"] = typeof(AutomaticStateMetadata),
        ["MANUAL"] = typeof(ManualStateMetadata),
    };

    public override StateMetadata? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("stateType", out var discProp))
            throw new JsonException("Missing discriminator property \"stateType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"stateType\"");
        return ((StateMetadata?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, StateMetadata value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
