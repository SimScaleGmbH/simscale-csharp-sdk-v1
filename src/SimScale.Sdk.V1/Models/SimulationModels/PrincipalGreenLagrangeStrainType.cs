using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrincipalGreenLagrangeStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: PrincipalGreenLagrangeStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL_GREEN_LAGRANGE";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
