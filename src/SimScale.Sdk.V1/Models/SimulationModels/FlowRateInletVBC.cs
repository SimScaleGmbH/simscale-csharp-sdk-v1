using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowRateInletVBC : OneOf_CustomFluidBCVelocity, OneOf_VelocityInletBCVelocity
{
    /// <summary>Schema name: FlowRateInletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_RATE_INLET_VELOCITY";

    [JsonPropertyName("flowRate")]
    public OneOf_FlowRateInletVBCFlowRate? FlowRate { get; set; }

}
