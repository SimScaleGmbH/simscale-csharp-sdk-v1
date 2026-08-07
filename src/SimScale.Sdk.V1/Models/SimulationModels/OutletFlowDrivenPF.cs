using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Phase fraction values are automatically computed.</summary>
public class OutletFlowDrivenPF : OneOf_PressureOutletBCPhaseFractionsV2, OneOf_VelocityOutletBCPhaseFractionsV2
{
    /// <summary>Phase fraction values are automatically computed. Schema name: OutletFlowDrivenPF</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTLET_FLOW_DRIVEN_PF";

}
