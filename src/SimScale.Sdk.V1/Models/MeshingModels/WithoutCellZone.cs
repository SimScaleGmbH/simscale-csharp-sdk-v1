using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class WithoutCellZone : OneOf_SurfaceRefinementHexDominantSnappyCellZone, OneOf_SurfaceRefinementCellZone
{
    /// <summary>Schema name: WithoutCellZone</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WITHOUT_CELL_ZONE";

}
