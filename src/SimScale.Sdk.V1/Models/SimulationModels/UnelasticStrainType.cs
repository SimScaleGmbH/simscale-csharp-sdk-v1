using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class UnelasticStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: UnelasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "UNELASTIC";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
