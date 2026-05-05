using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The Equation of state describes the relation between density of a fluid and the fluid pressure and temperature. The available options are:Rho const: Fluid density is assumed constant.Incompressibel perfect gas: The fluid is assumed to be an 'Ideal Gas' that is incompressible by pressure. But, fluid density can change due to temperature.Perfect gas: Fluid is assumed to be an 'Ideal Gas' and obeys the 'Ideal Gas Law'.Perfect fluid: Fluid density can change due to pressure and temperature with respect to a base value.Adiabatic perfect fluid: The fluid is a perfect fluid which is adiabatic in nature. Learn more.</summary>
public class AdiabaticPerfectFluidEquationOfState : OneOf_HConstThermoEquationOfState
{
    /// <summary>The Equation of state describes the relation between density of a fluid and the fluid pressure and temperature. The a...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADIABATIC_PERFECT_FLUID";

    [JsonPropertyName("referencePressure")]
    public Dimensional_Pressure? ReferencePressure { get; set; }

    [JsonPropertyName("referenceDensity")]
    public Dimensional_Density? ReferenceDensity { get; set; }

    /// <summary>Specify the isentropic exponent. This parameter characterizes changes in density due to pressure. A Larger isentropic...</summary>
    [JsonPropertyName("isentropicExponent")]
    public double? IsentropicExponent { get; set; }

    [JsonPropertyName("pressureOffset")]
    public Dimensional_Pressure? PressureOffset { get; set; }

    /// <summary>Energy provides the methods for the form of energy to be used. The options are:Sensible enthalpy: The enthalpy form o...</summary>
    [JsonPropertyName("energy")]
    public string? Energy { get; set; }

}
