using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteHumidityValue : OneOf_FixedValueRHBCHumidityValue, OneOf_InletOutletRHBCHumidityValue
{
    /// <summary>Schema name: AbsoluteHumidityValue</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE_HUMIDITY_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_Density? Value { get; set; }

}
