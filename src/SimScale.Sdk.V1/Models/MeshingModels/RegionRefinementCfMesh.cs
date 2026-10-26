using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Volume custom sizing refines all cells inside the assigned geometry primitives (cartesian box, cylinder or sphere) or solid CAD bodies to the given maximum edge length. Use it to refine regions of interest away from surfaces, for example wakes or jets. The refinement always applies to the inside of the assigned primitives and bodies. An assigned body must also be the meshed region itself (with physics-based meshing, the volume with the material assignment), a cell zone or, with physics-based meshing, a volume assigned to an advanced concept such as a rotating zone or porous medium.</summary>
public class RegionRefinementCfMesh
{
    /// <summary>Volume custom sizing refines all cells inside the assigned geometry primitives (cartesian box, cylinder or sphere) or...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_REFINEMENT_CF_MESH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinement")]
    public InsideRegionRefinementWithLength? Refinement { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
