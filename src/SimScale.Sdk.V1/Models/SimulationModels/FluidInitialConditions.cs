using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidInitialConditions
{
    [JsonPropertyName("pressure")]
    public DimensionalInitialConditionDomains_Pressure? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public DimensionalInitialConditionDomains_Pressure? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressure")]
    public DimensionalInitialConditionDomains_Pressure? GaugePressure { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public DimensionalInitialConditionDomains_Pressure? GaugePressureRgh { get; set; }

    [JsonPropertyName("velocity")]
    public DimensionalVectorInitialConditionDomains_Speed? Velocity { get; set; }

    [JsonPropertyName("temperature")]
    public DimensionalInitialConditionDomains_Temperature? Temperature { get; set; }

    [JsonPropertyName("turbulentKineticEnergy")]
    public DimensionalInitialConditionDomains_TurbulenceKineticEnergy? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("omegaDissipationRate")]
    public DimensionalInitialConditionDomains_SpecificTurbulenceDissipationRate? OmegaDissipationRate { get; set; }

    [JsonPropertyName("epsilonDissipationRate")]
    public DimensionalInitialConditionDomains_TurbulentDissipation? EpsilonDissipationRate { get; set; }

    [JsonPropertyName("nuTilda")]
    public DimensionalInitialConditionDomains_KinematicViscosity? NuTilda { get; set; }

    [JsonPropertyName("passiveScalars")]
    public List<DimensionalInitialConditionDomains_Dimensionless>? PassiveScalars { get; set; }

    [JsonPropertyName("phaseFraction")]
    public DimensionalInitialConditionDomains_Dimensionless? PhaseFraction { get; set; }

    [JsonPropertyName("phaseFractions")]
    public DimensionlessInitialConditionDomains? PhaseFractions { get; set; }

    [JsonPropertyName("massFractions")]
    public FractionValuesInitialConditions? MassFractions { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public DimensionalInitialConditionDomains_Dimensionless? RelativeHumidity { get; set; }

}
