using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowDependentValuePFBC : OneOf_CustomFluidBCPhaseFraction, OneOf_VelocityOutletBCPhaseFraction
{
    /// <summary>Schema name: FlowDependentValuePFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_DEPENDENT_VALUE";

    [JsonPropertyName("lowerBound")]
    public double? LowerBound { get; set; }

    [JsonPropertyName("upperBound")]
    public double? UpperBound { get; set; }

}
