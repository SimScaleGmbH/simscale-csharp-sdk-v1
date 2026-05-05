using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowRateMeanOutletVBC : OneOf_VelocityOutletBCVelocity
{
    /// <summary>Schema name: FlowRateMeanOutletVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOW_RATE_MEAN_OUTLET_VELOCITY";

    [JsonPropertyName("flowRate")]
    public OneOf_FlowRateMeanOutletVBCFlowRate? FlowRate { get; set; }

}
