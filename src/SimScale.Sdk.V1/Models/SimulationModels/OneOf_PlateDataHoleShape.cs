using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Shape of holes in perforated plate.</summary>
[JsonConverter(typeof(OneOf_PlateDataHoleShapeConverter))]
public interface OneOf_PlateDataHoleShape { }

internal class OneOf_PlateDataHoleShapeConverter : JsonConverter<OneOf_PlateDataHoleShape>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GENERAL"] = typeof(GeneralHoleShape),
        ["CIRCULAR"] = typeof(CircularHoleShape),
    };

    public override OneOf_PlateDataHoleShape? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PlateDataHoleShape?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PlateDataHoleShape value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
