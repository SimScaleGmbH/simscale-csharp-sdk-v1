using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPrincipalElasticStrainType : OneOf_MarcStrainFieldSelectionStrainType
{
    /// <summary>Schema name: MarcPrincipalElasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL_ELASTIC";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
