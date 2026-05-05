using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>It specifies the mass fraction values of the back flow. If there is no back flow, the values are ignored.</summary>
public class OutletBackFlowMFValues
{
    /// <summary>It specifies the mass fraction values of the back flow. If there is no back flow, the values are ignored. Schema name...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTLET_BACK_FLOW_MF_VALUES";

    [JsonPropertyName("backFlowMassFractions")]
    public List<FixedValueMassFractionBC>? BackFlowMassFractions { get; set; }

}
