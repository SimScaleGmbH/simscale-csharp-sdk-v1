using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalNonLinearStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: TotalNonLinearStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_NONLINEAR";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
