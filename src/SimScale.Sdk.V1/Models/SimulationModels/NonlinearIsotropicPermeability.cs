using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NonlinearIsotropicPermeability : OneOf_ElectromagneticMaterialMagneticPermeabilityType
{
    /// <summary>Schema name: NonlinearIsotropicPermeability</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NONLINEAR_ISOTROPIC";

    [JsonPropertyName("bhCurve")]
    public DimensionalFunction_MagneticFluxDensity? BhCurve { get; set; }

}
