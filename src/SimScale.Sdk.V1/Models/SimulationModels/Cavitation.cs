using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Cavitation
{
    [JsonPropertyName("vaporMolecularWeight")]
    public Dimensional_MolarMass? VaporMolecularWeight { get; set; }

    [JsonPropertyName("liquidBulkModulus")]
    public Dimensional_Pressure? LiquidBulkModulus { get; set; }

    /// <summary>The liquid bulk modulus coefficient B1 accounts for a linear rate of change in the liquid bulk modulus with respect t...</summary>
    [JsonPropertyName("liquidBulkModulusCoefficient")]
    public double? LiquidBulkModulusCoefficient { get; set; }

    [JsonPropertyName("liquidReferencePressure")]
    public Dimensional_Pressure? LiquidReferencePressure { get; set; }

    [JsonPropertyName("saturationPressure")]
    public Dimensional_Pressure? SaturationPressure { get; set; }

    [JsonPropertyName("liquidTemperature")]
    public Dimensional_Temperature? LiquidTemperature { get; set; }

}
