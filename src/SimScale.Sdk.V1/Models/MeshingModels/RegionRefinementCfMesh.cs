using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class RegionRefinementCfMesh
{
    /// <summary>Schema name: RegionRefinementCfMesh</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_REFINEMENT_CF_MESH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinement")]
    public InsideRegionRefinementWithLength? Refinement { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
