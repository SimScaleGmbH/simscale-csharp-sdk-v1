using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Automatic and Manual mesh settings. Learn more.Note: Mesh fineness impacts the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.</summary>
public class PacefishMeshLegacy : OneOf_IncompressiblePacefishMeshSettingsNew
{
    /// <summary>Choose between Automatic and Manual mesh settings. Learn more.Note: Mesh fineness impacts the accuracy of your result...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PACEFISH_MESH_LEGACY";

    [JsonPropertyName("fineness")]
    public string? Fineness { get; set; }

    [JsonPropertyName("progressiveRefinement")]
    public ProgressiveRefinement? ProgressiveRefinement { get; set; }

    [JsonPropertyName("referenceLength")]
    public Dimensional_Length? ReferenceLength { get; set; }

    [JsonPropertyName("reynoldsScalingType")]
    public ManualReynoldsScaling? ReynoldsScalingType { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_PacefishMeshLegacyRefinements>? Refinements { get; set; }

}
