using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

[JsonConverter(typeof(OneOf_SimmetrixMeshingSolidRefinementsConverter))]
public interface OneOf_SimmetrixMeshingSolidRefinements { }

internal class OneOf_SimmetrixMeshingSolidRefinementsConverter : JsonConverter<OneOf_SimmetrixMeshingSolidRefinements>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["REGION_LENGTH"] = typeof(RegionRefinementWithLength),
        ["SURFACE_CUSTOM_SIZING"] = typeof(SurfaceCustomSizing),
        ["VOLUME_CUSTOM_SIZING"] = typeof(VolumeCustomSizing),
        ["SIMMETRIX_LOCAL_SIZING_V10"] = typeof(SimmetrixLocalSizingRefinement),
        ["SIMMETRIX_BOUNDARY_LAYER_V13"] = typeof(SimmetrixBoundaryLayerRefinement),
        ["SIMMETRIX_SWEPT_MESH_REFINEMENT"] = typeof(SimmetrixSweptMeshRefinement),
        ["SIMMETRIX_THIN_SECTION_MESH_REFINEMENT"] = typeof(SimmetrixThinSectionMeshRefinement),
        ["SIMMETRIX_EXTRUSION_MESH_REFINEMENT"] = typeof(SimmetrixExtrusionMeshRefinement),
    };

    public override OneOf_SimmetrixMeshingSolidRefinements? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixMeshingSolidRefinements?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixMeshingSolidRefinements value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
