using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MagneticFluxDensityFieldSelection : OneOf_ElectromagneticResultControlProbePointFieldSelection
{
    /// <summary>Schema name: MagneticFluxDensityFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAGNETIC_FLUX_DENSITY";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
