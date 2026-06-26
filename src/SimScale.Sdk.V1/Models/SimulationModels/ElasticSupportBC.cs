using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The elastic support constraint can be used to model an elastic foundation between the assigned surfaces and the rigid ground. Additionally it can be used to prevent rigid body motions in a nonlinear analysis. The constraint acts on tension and compression forces and all stiffness values are expressed in the global coordinate system.Learn more.</summary>
public class ElasticSupportBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>The elastic support constraint can be used to model an elastic foundation between the assigned surfaces and the rigid...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELASTIC_SUPPORT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("springStiffness")]
    public OneOf_ElasticSupportBCSpringStiffness? SpringStiffness { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
