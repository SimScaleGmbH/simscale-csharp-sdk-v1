using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecificHumidityValue : OneOf_InletOutletRHBCHumidityValue, OneOf_FixedValueRHBCHumidityValue
{
    /// <summary>Schema name: SpecificHumidityValue</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIC_HUMIDITY_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_MassFraction? Value { get; set; }

}
