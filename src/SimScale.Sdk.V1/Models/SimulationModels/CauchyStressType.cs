using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CauchyStressType : OneOf_StressFieldSelectionStressType
{
    /// <summary>Schema name: CauchyStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CAUCHY";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
