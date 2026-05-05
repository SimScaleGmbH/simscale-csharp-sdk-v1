using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>You can create cell zones in your mesh by assigning this option to one or more of your CAD bodies. They can be later defined as Rotating Zones or Porosity Volumes, among others. Check these options under “Advanced Concepts” in the simulation tree.</summary>
[JsonConverter(typeof(OneOf_SurfaceRefinementHexDominantSnappyCellZoneConverter))]
public interface OneOf_SurfaceRefinementHexDominantSnappyCellZone { }

internal class OneOf_SurfaceRefinementHexDominantSnappyCellZoneConverter : JsonConverter<OneOf_SurfaceRefinementHexDominantSnappyCellZone>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["WITHOUT_CELL_ZONE"] = typeof(WithoutCellZone),
        ["WITH_CELL_ZONE_V11"] = typeof(WithCellZone),
    };

    public override OneOf_SurfaceRefinementHexDominantSnappyCellZone? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SurfaceRefinementHexDominantSnappyCellZone?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SurfaceRefinementHexDominantSnappyCellZone value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
