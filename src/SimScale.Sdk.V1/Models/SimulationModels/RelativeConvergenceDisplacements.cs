using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeConvergenceDisplacements : OneOf_DisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: RelativeConvergenceDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    /// <summary>The ratio of the maximum displacement change in the current iteration to the maximum displacement in the current incr...</summary>
    [JsonPropertyName("relativeDisplacementTolerance")]
    public double? RelativeDisplacementTolerance { get; set; }

    [JsonPropertyName("relativeRotationTolerance")]
    public double? RelativeRotationTolerance { get; set; }

}
