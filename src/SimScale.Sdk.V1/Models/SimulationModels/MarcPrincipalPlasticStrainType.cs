using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPrincipalPlasticStrainType : OneOf_MarcStrainFieldSelectionStrainType
{
    /// <summary>Schema name: MarcPrincipalPlasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL_PLASTIC";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
