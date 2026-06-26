using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The Thermo models are used to calculate the specific heat at constant pressure (Cp) for the fluid. The available models are:hConst: This model assumes a constant value for specific heat at fixed pressure (Cp). eConst: This model assumes a constant value for the specific heat at fixed volume (Cv).</summary>
public class HConstThermo : OneOf_SutherlandTransportThermo, OneOf_ConstTransportThermo
{
    /// <summary>The Thermo models are used to calculate the specific heat at constant pressure (Cp) for the fluid. The available mode...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HCONST";

    [JsonPropertyName("specificHeat")]
    public Dimensional_SpecificHeat? SpecificHeat { get; set; }

    [JsonPropertyName("specificHeatFunction")]
    public DimensionalFunction_SpecificHeat? SpecificHeatFunction { get; set; }

    [JsonPropertyName("equationOfState")]
    public OneOf_HConstThermoEquationOfState? EquationOfState { get; set; }

}
