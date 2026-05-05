using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicThermalConductivityMethod
{
    /// <summary>Schema name: IsotropicThermalConductivityMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_THERMAL_CONDUCTIVITY";

    [JsonPropertyName("thermalConductivity")]
    public DimensionalFunction_ThermalConductivity? ThermalConductivity { get; set; }

}
