using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AreaAverageResultControl : OneOf_FluidResultControlsSurfaceData
{
    /// <summary>Schema name: AreaAverageResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AREA_AVERAGE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_AreaAverageResultControlWriteControl? WriteControl { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
