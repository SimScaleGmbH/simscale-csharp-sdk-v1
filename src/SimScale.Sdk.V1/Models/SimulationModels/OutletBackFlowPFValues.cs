using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>It specifies the phase fraction values of the back flow. If there is no back flow, the values are ignored.</summary>
public class OutletBackFlowPFValues : OneOf_VelocityOutletBCPhaseFractionsV2, OneOf_PressureOutletBCPhaseFractionsV2
{
    /// <summary>It specifies the phase fraction values of the back flow. If there is no back flow, the values are ignored. Schema nam...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTLET_BACK_FLOW_PF_VALUES";

    [JsonPropertyName("backFlowPhaseFractions")]
    public List<FixedValuePhaseFractionBC>? BackFlowPhaseFractions { get; set; }

}
