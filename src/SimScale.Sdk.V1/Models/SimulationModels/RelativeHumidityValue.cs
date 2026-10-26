using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeHumidityValue : OneOf_FixedValueRHBCHumidityValue, OneOf_InletOutletRHBCHumidityValue
{
    /// <summary>Schema name: RelativeHumidityValue</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE_HUMIDITY_VALUE";

    [JsonPropertyName("value")]
    public double? Value { get; set; }

}
