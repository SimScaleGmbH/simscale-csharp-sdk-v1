using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Accounts for heat transfer due to thermal radiation between surfaces.</summary>
public class RadiationHeatFlux : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Accounts for heat transfer due to thermal radiation between surfaces. Schema name: RadiationHeatFlux</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RADIATION_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("emissivity")]
    public DimensionalFunction_Dimensionless? Emissivity { get; set; }

    [JsonPropertyName("ambientTemperature")]
    public DimensionalFunction_Temperature? AmbientTemperature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
