using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueRHBC
{
    /// <summary>Schema name: FixedValueRHBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("humidityValue")]
    public OneOf_FixedValueRHBCHumidityValue? HumidityValue { get; set; }

}
