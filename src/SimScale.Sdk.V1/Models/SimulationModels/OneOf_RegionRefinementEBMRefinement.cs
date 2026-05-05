using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between the following refinement modes:Inside: Refines all the mesh cells inside the selected volumes up to the specified cell edge length.Distance:Refines the mesh cells according to the distance to the surface of the assigned volume(s). The Distance mode can accommodate different refinement levels at multiple distances.</summary>
[JsonConverter(typeof(OneOf_RegionRefinementEBMRefinementConverter))]
public interface OneOf_RegionRefinementEBMRefinement { }

internal class OneOf_RegionRefinementEBMRefinementConverter : JsonConverter<OneOf_RegionRefinementEBMRefinement>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["INSIDE"] = typeof(InsideRegionRefinementWithLength),
        ["DISTANCE"] = typeof(DistanceRegionRefinementWithLength),
    };

    public override OneOf_RegionRefinementEBMRefinement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_RegionRefinementEBMRefinement?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_RegionRefinementEBMRefinement value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
