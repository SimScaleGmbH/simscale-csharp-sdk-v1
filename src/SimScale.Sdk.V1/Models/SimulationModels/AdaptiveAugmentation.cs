using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdaptiveAugmentation
{
    /// <summary>Define the percentage of additional Newton Iterations that should be allowed to be used if convergence is not reached...</summary>
    [JsonPropertyName("fieldChangeTargetValue")]
    public double? FieldChangeTargetValue { get; set; }

}
