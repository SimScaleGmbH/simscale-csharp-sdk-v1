using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ForcesMomentsResultControl : OneOf_FluidResultControlsForcesMoments
{
    /// <summary>Schema name: ForcesMomentsResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCES_AND_MOMENTS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("centerOfRotation")]
    public DimensionalVector_Length? CenterOfRotation { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_ForcesMomentsResultControlWriteControl? WriteControl { get; set; }

    /// <summary>It defines the point in simulation where the result output data extraction starts. For instance, Fraction from end of...</summary>
    [JsonPropertyName("fractionFromEnd")]
    public double? FractionFromEnd { get; set; }

    /// <summary>When this switch is activated, statistical data for the selected forces and moments will be exported:Minimum (MIN)Max...</summary>
    [JsonPropertyName("exportStatistics")]
    public bool? ExportStatistics { get; set; }

    /// <summary>When this switch is activated, forces and moments will be calculated cumulatively on all assignments. When deactivate...</summary>
    [JsonPropertyName("groupAssignments")]
    public bool? GroupAssignments { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
