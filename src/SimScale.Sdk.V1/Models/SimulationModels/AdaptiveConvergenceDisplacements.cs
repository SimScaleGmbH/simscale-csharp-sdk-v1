using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdaptiveConvergenceDisplacements : OneOf_DisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AdaptiveConvergenceDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADAPTIVE";

    /// <summary>The ratio of the maximum displacement change in the current iteration to the maximum displacement in the current incr...</summary>
    [JsonPropertyName("relativeDisplacementTolerance")]
    public double? RelativeDisplacementTolerance { get; set; }

    [JsonPropertyName("maxDisplacementIncrement")]
    public Dimensional_Length? MaxDisplacementIncrement { get; set; }

    [JsonPropertyName("relativeRotationTolerance")]
    public double? RelativeRotationTolerance { get; set; }

    [JsonPropertyName("maxRotationIncrement")]
    public Dimensional_Angle? MaxRotationIncrement { get; set; }

}
