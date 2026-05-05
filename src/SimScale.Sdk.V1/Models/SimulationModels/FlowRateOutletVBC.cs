using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowRateOutletVBC : OneOf_VelocityOutletBCVelocity
{
    /// <summary>Schema name: FlowRateOutletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_RATE_OUTLET_VELOCITY";

    [JsonPropertyName("flowRate")]
    public OneOf_FlowRateOutletVBCFlowRate? FlowRate { get; set; }

}
