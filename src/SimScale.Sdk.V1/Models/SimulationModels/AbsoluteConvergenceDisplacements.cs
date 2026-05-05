using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteConvergenceDisplacements : OneOf_DisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AbsoluteConvergenceDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    [JsonPropertyName("maxDisplacementIncrement")]
    public Dimensional_Length? MaxDisplacementIncrement { get; set; }

    [JsonPropertyName("maxRotationIncrement")]
    public Dimensional_Angle? MaxRotationIncrement { get; set; }

}
