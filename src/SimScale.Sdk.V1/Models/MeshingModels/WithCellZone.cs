using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class WithCellZone : OneOf_SurfaceRefinementCellZone, OneOf_SurfaceRefinementHexDominantSnappyCellZone
{
    /// <summary>Schema name: WithCellZone</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WITH_CELL_ZONE_V11";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
