using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

[JsonConverter(typeof(OneOf_AutomaticLayerOnLayerTypeConverter))]
public interface OneOf_AutomaticLayerOnLayerType { }

internal class OneOf_AutomaticLayerOnLayerTypeConverter : JsonConverter<OneOf_AutomaticLayerOnLayerType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FRACTIONAL_HEIGHT_1"] = typeof(FractionalHeight1),
        ["FRACTIONAL_HEIGHT_2"] = typeof(FractionalHeight2),
        ["GEOMETRIC_GROWTH"] = typeof(GeometricGrowth),
        ["FIRST_LAYER_GROWTH"] = typeof(FirstLayerGrowth),
    };

    public override OneOf_AutomaticLayerOnLayerType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AutomaticLayerOnLayerType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AutomaticLayerOnLayerType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
