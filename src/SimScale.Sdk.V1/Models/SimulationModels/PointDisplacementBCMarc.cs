using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition prescribes a specific translation or rotation value at a single remote point defined via a point geometry primitive.Important remarks:The assigned point geometry primitive point needs to be connected to the CAD model via an RBE3 or RBE2 connector.Gradually ramp the displacement and rotation values via a table or formula depending on time [t], otherwise the full movement will be applied on the first iteration already and the simulation might fail to converge.</summary>
public class PointDisplacementBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This boundary condition prescribes a specific translation or rotation value at a single remote point defined via a po...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POINT_DISPLACEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacement")]
    public DimensionalPartialVectorFunction_Length? Displacement { get; set; }

    [JsonPropertyName("rotation")]
    public DimensionalPartialVectorFunction_Angle? Rotation { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
