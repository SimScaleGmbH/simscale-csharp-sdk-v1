using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HeatTransferCoefficients : OneOf_HeatExchangerSourceHeatExchangerMode
{
    /// <summary>Schema name: HeatTransferCoefficients</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_TRANSFER_COEFFICIENTS";

    [JsonPropertyName("refTemperature")]
    public DimensionalFunction_Temperature? RefTemperature { get; set; }

    [JsonPropertyName("heatTransferCoefficient")]
    public DimensionalFunction_ThermalTransmittance? HeatTransferCoefficient { get; set; }

    [JsonPropertyName("surfaceAreaDensity")]
    public Dimensional_Absorptivity? SurfaceAreaDensity { get; set; }

    /// <summary>Sampling method for the field temperature (T) in T - Tref. This indicates whether the temperature (T) is averaged on...</summary>
    [JsonPropertyName("heatDistribution")]
    public string? HeatDistribution { get; set; }

}
