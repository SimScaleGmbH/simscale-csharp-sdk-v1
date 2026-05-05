using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowRateStableOutletVBC : OneOf_VelocityOutletBCVelocity
{
    /// <summary>Schema name: FlowRateStableOutletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_RATE_STABLE_OUTLET_VELOCITY";

    [JsonPropertyName("flowRate")]
    public OneOf_FlowRateStableOutletVBCFlowRate? FlowRate { get; set; }

}
