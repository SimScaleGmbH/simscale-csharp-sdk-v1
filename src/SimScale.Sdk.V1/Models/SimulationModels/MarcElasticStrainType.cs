using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcElasticStrainType : OneOf_MarcStrainFieldSelectionStrainType
{
    /// <summary>Schema name: MarcElasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELASTIC";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
