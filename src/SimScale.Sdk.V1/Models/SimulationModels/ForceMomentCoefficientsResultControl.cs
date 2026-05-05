using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ForceMomentCoefficientsResultControl : OneOf_FluidResultControlsForcesMoments
{
    /// <summary>Schema name: ForceMomentCoefficientsResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE_AND_MOMENT_COEFFICIENTS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("centerOfRotation")]
    public DimensionalVector_Length? CenterOfRotation { get; set; }

    [JsonPropertyName("liftDirection")]
    public DimensionalVector_Length? LiftDirection { get; set; }

    [JsonPropertyName("dragDirection")]
    public DimensionalVector_Length? DragDirection { get; set; }

    [JsonPropertyName("pitchAxis")]
    public DimensionalVector_Length? PitchAxis { get; set; }

    [JsonPropertyName("freestreamVelocityMagnitude")]
    public Dimensional_Speed? FreestreamVelocityMagnitude { get; set; }

    [JsonPropertyName("referenceLength")]
    public Dimensional_Length? ReferenceLength { get; set; }

    [JsonPropertyName("referenceAreaValue")]
    public Dimensional_Area? ReferenceAreaValue { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_ForceMomentCoefficientsResultControlWriteControl? WriteControl { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
