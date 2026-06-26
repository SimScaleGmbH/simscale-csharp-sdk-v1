using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueTurbulence : OneOf_NaturalConvectionInletOutletBCTurbulence, OneOf_FanBCTurbulence, OneOf_PressureInletBCTurbulence, OneOf_VelocityInletBCTurbulence
{
    /// <summary>Schema name: FixedValueTurbulence</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE_TURBULENCE";

    [JsonPropertyName("turbulentKineticEnergy")]
    public DimensionalFunction_TurbulenceKineticEnergy? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("epsilonDissipationRate")]
    public DimensionalFunction_TurbulentDissipation? EpsilonDissipationRate { get; set; }

    [JsonPropertyName("omegaDissipationRate")]
    public DimensionalFunction_SpecificTurbulenceDissipationRate? OmegaDissipationRate { get; set; }

}
