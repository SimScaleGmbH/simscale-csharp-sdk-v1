using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Bolt preload boundary condition helps to model pre-stressed bolts in a CAD geometry for structural analysis. Enter a preload force to be assigned to cylindrical faces representing the shank of the bolt. Note:These faces should be continuous and not be assigned to contact definitions.Each bolt gets only one load, if multiple faces for the same bolt are assigned, they get ignored.The applied load does not get distributed if multiple bolts are assigned. Learn more.</summary>
public class BoltPreloadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>Bolt preload boundary condition helps to model pre-stressed bolts in a CAD geometry for structural analysis. Enter a...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOLT_PRELOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("preload")]
    public ForcePreload? Preload { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
