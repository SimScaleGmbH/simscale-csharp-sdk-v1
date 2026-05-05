using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Define how the layers should be distributed within the overall layer thickness:Specify growth rate: Define the growth rate between adjacent layers. Specify first layer thickness: Define the absolute thickness of the first layer. The remaining layers are distributed automatically. Choose this option for example to strictly control the y+ value. Specify first layer and total absolute thickness: Define the absolute value of the first layer and the total layer thickness. The growth rate is computed automatically using a geometric progression.</summary>
[JsonConverter(typeof(OneOf_SimmetrixBoundaryLayerRefinementLayerTypeConverter))]
public interface OneOf_SimmetrixBoundaryLayerRefinementLayerType { }

internal class OneOf_SimmetrixBoundaryLayerRefinementLayerTypeConverter : JsonConverter<OneOf_SimmetrixBoundaryLayerRefinementLayerType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FRACTIONAL_HEIGHT_1"] = typeof(FractionalHeight1),
        ["FRACTIONAL_HEIGHT_2"] = typeof(FractionalHeight2),
        ["GEOMETRIC_GROWTH"] = typeof(GeometricGrowth),
        ["FIRST_LAYER_GROWTH"] = typeof(FirstLayerGrowth),
    };

    public override OneOf_SimmetrixBoundaryLayerRefinementLayerType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixBoundaryLayerRefinementLayerType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixBoundaryLayerRefinementLayerType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
