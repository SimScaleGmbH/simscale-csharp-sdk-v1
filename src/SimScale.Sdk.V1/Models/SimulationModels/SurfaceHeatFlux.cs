using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify the rate of heat transfer per unit area at the boundary. Used for heating or cooling surfaces.</summary>
public class SurfaceHeatFlux : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Specify the rate of heat transfer per unit area at the boundary. Used for heating or cooling surfaces. Schema name: S...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatFluxValue")]
    public DimensionalFunction_HeatFlux? HeatFluxValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
