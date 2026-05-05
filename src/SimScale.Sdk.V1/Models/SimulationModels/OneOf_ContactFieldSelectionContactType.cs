using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ContactFieldSelectionContactTypeConverter))]
public interface OneOf_ContactFieldSelectionContactType { }

internal class OneOf_ContactFieldSelectionContactTypeConverter : JsonConverter<OneOf_ContactFieldSelectionContactType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PRESSURE"] = typeof(ContactPressureType),
        ["NORMAL_FORCE"] = typeof(ContactNormalForceType),
        ["GAP"] = typeof(ContactGapType),
        ["STATE"] = typeof(ContactStateType),
    };

    public override OneOf_ContactFieldSelectionContactType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ContactFieldSelectionContactType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ContactFieldSelectionContactType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
