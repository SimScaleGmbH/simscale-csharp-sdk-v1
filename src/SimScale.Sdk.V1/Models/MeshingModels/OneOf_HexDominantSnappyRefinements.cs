using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

[JsonConverter(typeof(OneOf_HexDominantSnappyRefinementsConverter))]
public interface OneOf_HexDominantSnappyRefinements { }

internal class OneOf_HexDominantSnappyRefinementsConverter : JsonConverter<OneOf_HexDominantSnappyRefinements>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["REGION_LENGTH"] = typeof(RegionRefinementWithLength),
        ["SURFACE_HEX_DOMINANT_SNAPPY_V3"] = typeof(SurfaceRefinementHexDominantSnappy),
        ["FEATURE_HEX_DOMINANT_SNAPPY"] = typeof(FeatureRefinementHexDominantSnappy),
        ["LAYER_ADDITION_HEX_DOMINANT_SNAPPY"] = typeof(LayerAdditionHexDominantSnappy),
    };

    public override OneOf_HexDominantSnappyRefinements? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HexDominantSnappyRefinements?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HexDominantSnappyRefinements value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
