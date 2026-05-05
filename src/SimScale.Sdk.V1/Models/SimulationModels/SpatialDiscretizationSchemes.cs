using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpatialDiscretizationSchemes
{
    [JsonPropertyName("velocity")]
    public OneOf_SpatialDiscretizationSchemesVelocity? Velocity { get; set; }

    [JsonPropertyName("density")]
    public OneOf_SpatialDiscretizationSchemesDensity? Density { get; set; }

    [JsonPropertyName("turbulentKineticEnergy")]
    public OneOf_SpatialDiscretizationSchemesTurbulentKineticEnergy? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("turbulentEnergyDissipationRate")]
    public OneOf_SpatialDiscretizationSchemesTurbulentEnergyDissipationRate? TurbulentEnergyDissipationRate { get; set; }

    [JsonPropertyName("volumeOfFluid")]
    public OneOf_SpatialDiscretizationSchemesVolumeOfFluid? VolumeOfFluid { get; set; }

    [JsonPropertyName("internalEnergy")]
    public OneOf_SpatialDiscretizationSchemesInternalEnergy? InternalEnergy { get; set; }

    [JsonPropertyName("gasMixtureTransport")]
    public OneOf_SpatialDiscretizationSchemesGasMixtureTransport? GasMixtureTransport { get; set; }

}
