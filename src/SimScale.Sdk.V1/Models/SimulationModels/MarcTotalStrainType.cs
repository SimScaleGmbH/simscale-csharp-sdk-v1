using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcTotalStrainType : OneOf_MarcStrainFieldSelectionStrainType
{
    /// <summary>Schema name: MarcTotalStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
