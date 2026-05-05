using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HeatExchangerPerformance : OneOf_HeatExchangerSourceHeatExchangerMode
{
    /// <summary>Schema name: HeatExchangerPerformance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_EXCHANGER_PERFORMANCE";

    [JsonPropertyName("refTemperature")]
    public DimensionalFunction_Temperature? RefTemperature { get; set; }

    [JsonPropertyName("performance")]
    public DimensionalFunction_TotalThermalTransmittance? Performance { get; set; }

}
