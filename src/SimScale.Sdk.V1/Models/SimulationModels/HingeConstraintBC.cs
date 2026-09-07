using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Replicate the behaviour of a freely rotating hinge fixed to the ground. Note that only a single face assignment is allowed. The assigned surface is constrained such that only rotational motion around the hinge axis is free. SimScale can automatically detect the axis of the hinge based on an assigned cylindrical surface, but the boundary condition also allows for a user-defined input.</summary>
public class HingeConstraintBC : OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>Replicate the behaviour of a freely rotating hinge fixed to the ground. Note that only a single face assignment is al...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HINGE_CONSTRAINT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("axisDefinition")]
    public OneOf_HingeConstraintBCAxisDefinition? AxisDefinition { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
