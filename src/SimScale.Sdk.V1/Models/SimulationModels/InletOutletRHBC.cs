using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletRHBC
{
    /// <summary>Schema name: InletOutletRHBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("humidityValue")]
    public OneOf_InletOutletRHBCHumidityValue? HumidityValue { get; set; }

}
