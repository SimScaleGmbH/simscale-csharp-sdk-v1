using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowRateMeanInletVBC : OneOf_CustomFluidBCVelocity, OneOf_VelocityInletBCVelocity
{
    /// <summary>Schema name: FlowRateMeanInletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_RATE_MEAN_INLET_VELOCITY";

    [JsonPropertyName("flowRate")]
    public OneOf_FlowRateMeanInletVBCFlowRate? FlowRate { get; set; }

}
