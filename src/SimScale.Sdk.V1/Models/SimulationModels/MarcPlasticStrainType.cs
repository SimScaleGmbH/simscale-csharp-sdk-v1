using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPlasticStrainType : OneOf_MarcStrainFieldSelectionStrainType
{
    /// <summary>Schema name: MarcPlasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PLASTIC";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
