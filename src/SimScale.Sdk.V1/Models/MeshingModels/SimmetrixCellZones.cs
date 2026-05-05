using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixCellZones
{
    /// <summary>Schema name: SimmetrixCellZones</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_CELL_ZONES";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
