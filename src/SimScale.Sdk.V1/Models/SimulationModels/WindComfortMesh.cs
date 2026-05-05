using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindComfortMesh
{
    [JsonPropertyName("windComfortFineness")]
    public OneOf_WindComfortMeshWindComfortFineness? WindComfortFineness { get; set; }

    [JsonPropertyName("automaticGapClosing")]
    public OneOf_WindComfortMeshAutomaticGapClosing? AutomaticGapClosing { get; set; }

    [JsonPropertyName("progressiveRefinement")]
    public ProgressiveRefinement? ProgressiveRefinement { get; set; }

    [JsonPropertyName("reynoldsScalingType")]
    public OneOf_WindComfortMeshReynoldsScalingType? ReynoldsScalingType { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_WindComfortMeshRefinements>? Refinements { get; set; }

}
