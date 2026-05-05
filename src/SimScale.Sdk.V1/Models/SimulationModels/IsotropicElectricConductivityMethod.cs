using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicElectricConductivityMethod : OneOf_ElectromagneticMaterialElectricConductivityType
{
    /// <summary>Schema name: IsotropicElectricConductivityMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_ELECTRIC_CONDUCTIVITY";

    [JsonPropertyName("electricConductivity")]
    public DimensionalFunction_ElectricConductivity? ElectricConductivity { get; set; }

}
