using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SecondOrderUpwindSpatialScheme : OneOf_SpatialDiscretizationSchemesVelocity, OneOf_SpatialDiscretizationSchemesDensity, OneOf_SpatialDiscretizationSchemesTurbulentKineticEnergy, OneOf_SpatialDiscretizationSchemesTurbulentEnergyDissipationRate, OneOf_SpatialDiscretizationSchemesVolumeOfFluid, OneOf_SpatialDiscretizationSchemesInternalEnergy, OneOf_SpatialDiscretizationSchemesGasMixtureTransport
{
    /// <summary>Schema name: SecondOrderUpwindSpatialScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "UPWIND_2ND";

}
