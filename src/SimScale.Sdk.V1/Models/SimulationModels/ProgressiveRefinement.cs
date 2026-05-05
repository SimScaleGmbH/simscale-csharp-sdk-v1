using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ProgressiveRefinement
{
    [JsonPropertyName("enableProgressiveRefinement")]
    public bool? EnableProgressiveRefinement { get; set; }

    [JsonPropertyName("baseRefinementFraction")]
    public double? BaseRefinementFraction { get; set; }

    [JsonPropertyName("fullRefinementFraction")]
    public double? FullRefinementFraction { get; set; }

}
