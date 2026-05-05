using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Use this boundary condition to define a plane of symmetry for the model by constraining the displacement normal to the plane. This allows you to simulate only a portion of a symmetric structure, significantly reducing computational requirements while maintaining physical accuracy.Important remarks:The symmetry plane acts like a contact surface for all surfaces of the assigned body which are not initially in contact with the plane. If there is an initial gap with a surface, which closes during the simulation, the contact will be activated and the surface will not pass through the symmetry plane.</summary>
public class SymmetryBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>Use this boundary condition to define a plane of symmetry for the model by constraining the displacement normal to th...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
