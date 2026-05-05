using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a boundary condition for the displacement vector variable. You can define prescribed values for the displacement of the assigned entities in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely.Important remarks:Gradually ramp the displacement values via a table or formula depending on time [t], otherwise the full movement will be applied on the first iteration already and the simulation might fail to converge.Choose 0 as value in order to fix your selection in place.</summary>
public class FixedValueBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This is a boundary condition for the displacement vector variable. You can define prescribed values for the displacem...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacement")]
    public DimensionalPartialVectorFunction_Length? Displacement { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
