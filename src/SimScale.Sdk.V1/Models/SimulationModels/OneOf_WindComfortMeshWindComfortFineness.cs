using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_WindComfortMeshWindComfortFinenessConverter))]
public interface OneOf_WindComfortMeshWindComfortFineness { }

internal class OneOf_WindComfortMeshWindComfortFinenessConverter : JsonConverter<OneOf_WindComfortMeshWindComfortFineness>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["VERY_COARSE"] = typeof(PacefishFinenessVeryCoarse),
        ["COARSE"] = typeof(PacefishFinenessCoarse),
        ["MODERATE"] = typeof(PacefishFinenessModerate),
        ["FINE"] = typeof(PacefishFinenessFine),
        ["VERY_FINE"] = typeof(PacefishFinenessVeryFine),
        ["TARGET_SIZE"] = typeof(PacefishFinenessTargetSize),
    };

    public override OneOf_WindComfortMeshWindComfortFineness? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WindComfortMeshWindComfortFineness?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WindComfortMeshWindComfortFineness value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
