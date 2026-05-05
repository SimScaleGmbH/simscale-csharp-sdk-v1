using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Automatic and Manual mesh settings. Learn more.Note: Mesh fineness impacts the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.</summary>
public class PacefishAutomesh : OneOf_IncompressiblePacefishMeshSettingsNew
{
    /// <summary>Choose between Automatic and Manual mesh settings. Learn more.Note: Mesh fineness impacts the accuracy of your result...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PACEFISH_AUTOMESH";

    [JsonPropertyName("newFineness")]
    public OneOf_PacefishAutomeshNewFineness? NewFineness { get; set; }

    [JsonPropertyName("automaticGapClosing")]
    public OneOf_PacefishAutomeshAutomaticGapClosing? AutomaticGapClosing { get; set; }

    [JsonPropertyName("progressiveRefinement")]
    public ProgressiveRefinement? ProgressiveRefinement { get; set; }

    [JsonPropertyName("referenceLengthComputation")]
    public OneOf_PacefishAutomeshReferenceLengthComputation? ReferenceLengthComputation { get; set; }

    [JsonPropertyName("reynoldsScalingType")]
    public OneOf_PacefishAutomeshReynoldsScalingType? ReynoldsScalingType { get; set; }

    [JsonPropertyName("primaryTopology")]
    public OneOf_PacefishAutomeshPrimaryTopology? PrimaryTopology { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_PacefishAutomeshRefinements>? Refinements { get; set; }

}
