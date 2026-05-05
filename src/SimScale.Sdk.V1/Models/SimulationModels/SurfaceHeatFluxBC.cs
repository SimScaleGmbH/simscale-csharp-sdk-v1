using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the heatflux per unit area that enters the body through the assigned faces. Negative sign determines flux leaving the body.</summary>
public class SurfaceHeatFluxBC : OneOf_ThermalMechanicalBoundaryConditions, OneOf_HeatTransferBoundaryConditions
{
    /// <summary>Define the heatflux per unit area that enters the body through the assigned faces. Negative sign determines flux leav...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatfluxValue")]
    public DimensionalFunction_HeatFlux? HeatfluxValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
