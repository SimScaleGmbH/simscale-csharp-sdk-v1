using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalPrincipalGreenLagrangeStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalPrincipalGreenLagrangeStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL_GREEN_LAGRANGE";

}
