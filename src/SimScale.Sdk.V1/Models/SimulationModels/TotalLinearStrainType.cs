using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalLinearStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: TotalLinearStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_LINEAR";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
