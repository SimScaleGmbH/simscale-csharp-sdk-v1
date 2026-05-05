using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalCauchyStressType : OneOf_StressResultControlItemStressType
{
    /// <summary>Schema name: GlobalCauchyStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CAUCHY";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
