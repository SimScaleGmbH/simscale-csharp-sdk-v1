using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalTotalStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalTotalStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
