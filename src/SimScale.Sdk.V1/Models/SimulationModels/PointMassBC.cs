using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define a Point mass boundary condition in order to insert an additional mass on a specific location of the active model.</summary>
public class PointMassBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions
{
    /// <summary>Define a Point mass boundary condition in order to insert an additional mass on a specific location of the active mod...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POINT_MASS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("mass")]
    public Dimensional_Mass? Mass { get; set; }

    [JsonPropertyName("massMomentOfInertia")]
    public DimensionalVector_MomentOfInertia? MassMomentOfInertia { get; set; }

    [JsonPropertyName("externalPoint")]
    public DimensionalVector_Length? ExternalPoint { get; set; }

    /// <summary>Choose the deformation behavior of the entity which the point mass is connected to. If deformable is selected, the en...</summary>
    [JsonPropertyName("deformationBehavior")]
    public string? DeformationBehavior { get; set; }

    [JsonPropertyName("enableSearchRadius")]
    public bool? EnableSearchRadius { get; set; }

    [JsonPropertyName("searchRadius")]
    public Dimensional_Length? SearchRadius { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
