using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HeatFlowCalculationResultControlItem : OneOf_SolidResultControlAreaCalculation
{
    /// <summary>Schema name: HeatFlowCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_FLOW_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
