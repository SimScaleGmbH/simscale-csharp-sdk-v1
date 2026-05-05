using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

[JsonConverter(typeof(OneOf_RegionRefinementWithLevelsRefinementConverter))]
public interface OneOf_RegionRefinementWithLevelsRefinement { }

internal class OneOf_RegionRefinementWithLevelsRefinementConverter : JsonConverter<OneOf_RegionRefinementWithLevelsRefinement>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["INSIDE"] = typeof(InsideRegionRefinementWithLevels),
        ["DISTANCE"] = typeof(DistanceRegionRefinementWithLevels),
        ["OUTSIDE"] = typeof(OutsideRegionRefinementWithLevels),
    };

    public override OneOf_RegionRefinementWithLevelsRefinement? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_RegionRefinementWithLevelsRefinement?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_RegionRefinementWithLevelsRefinement value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
