using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelaxationFactor
{
    /// <summary>With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt...</summary>
    [JsonPropertyName("pressureField")]
    public double? PressureField { get; set; }

    [JsonPropertyName("pressureRghField")]
    public double? PressureRghField { get; set; }

    [JsonPropertyName("passiveScalarEquation")]
    public double? PassiveScalarEquation { get; set; }

    /// <summary>With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt...</summary>
    [JsonPropertyName("velocityEquation")]
    public double? VelocityEquation { get; set; }

    [JsonPropertyName("velocity")]
    public double? Velocity { get; set; }

    [JsonPropertyName("temperatureEquation")]
    public double? TemperatureEquation { get; set; }

    [JsonPropertyName("temperatureField")]
    public double? TemperatureField { get; set; }

    [JsonPropertyName("densityField")]
    public double? DensityField { get; set; }

    /// <summary>With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt...</summary>
    [JsonPropertyName("enthalpyEquation")]
    public double? EnthalpyEquation { get; set; }

    /// <summary>With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt...</summary>
    [JsonPropertyName("internalEnergyEquation")]
    public double? InternalEnergyEquation { get; set; }

    [JsonPropertyName("turbulentKineticEnergyEquation")]
    public double? TurbulentKineticEnergyEquation { get; set; }

    [JsonPropertyName("omegaDissipationRateEquation")]
    public double? OmegaDissipationRateEquation { get; set; }

    [JsonPropertyName("epsilonDissipationRateEquation")]
    public double? EpsilonDissipationRateEquation { get; set; }

    [JsonPropertyName("turbulentKineticEnergy")]
    public double? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("turbulentEnergyDissipationRate")]
    public double? TurbulentEnergyDissipationRate { get; set; }

    [JsonPropertyName("nuTildaEquation")]
    public double? NuTildaEquation { get; set; }

    [JsonPropertyName("netRadiativeHeatFluxField")]
    public double? NetRadiativeHeatFluxField { get; set; }

    [JsonPropertyName("internalEnergy")]
    public double? InternalEnergy { get; set; }

    [JsonPropertyName("gasMixtureTransport")]
    public double? GasMixtureTransport { get; set; }

    [JsonPropertyName("radiativeIntensityRayEquation")]
    public double? RadiativeIntensityRayEquation { get; set; }

    [JsonPropertyName("radiativeIntensityRayField")]
    public double? RadiativeIntensityRayField { get; set; }

    [JsonPropertyName("specificHumidityEquation")]
    public double? SpecificHumidityEquation { get; set; }

    [JsonPropertyName("ageOfFluidEquation")]
    public double? AgeOfFluidEquation { get; set; }

    [JsonPropertyName("voltageField")]
    public double? VoltageField { get; set; }

}
