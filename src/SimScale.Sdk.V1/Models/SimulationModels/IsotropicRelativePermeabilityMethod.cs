using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicRelativePermeabilityMethod : OneOf_ElectromagneticMaterialMagneticPermeabilityType
{
    /// <summary>Schema name: IsotropicRelativePermeabilityMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_RELATIVE_MAGNETIC_PERMEABILITY";

    [JsonPropertyName("relativeMagneticPermeability")]
    public DimensionalFunction_Dimensionless? RelativeMagneticPermeability { get; set; }

}
