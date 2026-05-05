using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TrescaStressType : OneOf_StressFieldSelectionStressType
{
    /// <summary>Schema name: TrescaStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRESCA";

}
