using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a boundary condition for the displacement vector variable. You can define prescribed values for the displacement of the assigned groups in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely. Important remarks: Choose 0 as value in order to fix your selection.Do not constrain entities in directions where a load boundary condition is applied.Do not constrain entities with multiple Dirichlet boundary conditions in one direction (overconstrained).Do not constrain slave entities of Contact Constraints as they are constrained by the master in that direction (overconstrained).Learn more.</summary>
public class FixedValueBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a boundary condition for the displacement vector variable. You can define prescribed values for the displacem...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacement")]
    public DimensionalPartialVectorFunction_Length? Displacement { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
