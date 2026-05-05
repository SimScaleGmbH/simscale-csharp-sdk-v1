using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>The refinement type local element size allows the definition of local mesh sizings on particular faces or solids. This can be used to increase the mesh efficiency by using smaller elements only where needed, for example on contact surfaces, fillets or other regions with potentially large stress gradients. The figure shows a mesh of a bolted connection with local refinements on the contact surfaces.</summary>
public class SubmeshRefinement
{
    /// <summary>The refinement type local element size allows the definition of local mesh sizings on particular faces or solids. Thi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUBMESH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sizing")]
    public OneOf_SubmeshRefinementSizing? Sizing { get; set; }

    /// <summary>This parameter determines if quadrangular surface elements shall be allowed. When disabled, only triangles will be us...</summary>
    [JsonPropertyName("allowQuadrangles")]
    public bool? AllowQuadrangles { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
