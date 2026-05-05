using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalPrincipalStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalPrincipalStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL";

}
