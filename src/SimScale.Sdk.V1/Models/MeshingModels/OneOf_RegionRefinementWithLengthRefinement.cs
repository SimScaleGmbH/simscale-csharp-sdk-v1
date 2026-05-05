using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Choose between the following refinement modes:Inside: Refines all volume mesh cells inside the selected volumes up to the specified cell edge length.Outside: Refines the mesh cells outside of the specified area up to the specified cell edge length.Distance: Refines mesh cells according to the distance to the surface of the assigned volume(s). The Distance mode can accommodate different refinement levels at multiple distances.</summary>
[JsonConverter(typeof(OneOf_RegionRefinementWithLengthRefinementConverter))]
public interface OneOf_RegionRefinementWithLengthRefinement { }

internal class OneOf_RegionRefinementWithLengthRefinementConverter : JsonConverter<OneOf_RegionRefinementWithLengthRefinement>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["INSIDE"] = typeof(InsideRegionRefinementWithLength),
        ["DISTANCE"] = typeof(DistanceRegionRefinementWithLength),
        ["OUTSIDE"] = typeof(OutsideRegionRefinementWithLength),
    };

    public override OneOf_RegionRefinementWithLengthRefinement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_RegionRefinementWithLengthRefinement?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_RegionRefinementWithLengthRefinement value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
