using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>If a fixed support boundary condition is used, all degrees of freedom of the selected entities are fixed at zero. This constraint is often used to model a fixation to the ground or an undeformable part.Learn more.</summary>
public class FixedSupportBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>If a fixed support boundary condition is used, all degrees of freedom of the selected entities are fixed at zero. Thi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_SUPPORT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
