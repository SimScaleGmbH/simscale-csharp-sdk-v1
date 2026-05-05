using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrincipalStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: PrincipalStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
