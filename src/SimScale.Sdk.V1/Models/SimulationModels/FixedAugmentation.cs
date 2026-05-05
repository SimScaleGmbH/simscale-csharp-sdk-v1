using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedAugmentation
{
    /// <summary>Newton Iteration threshold defines the threshold below which the actual number of Newton Iterations has to fall in or...</summary>
    [JsonPropertyName("newtonIterationThreshold")]
    public int? NewtonIterationThreshold { get; set; }

    /// <summary>Newton Iteration threshold defines the threshold below which the actual number of Newton Iterations has to fall in or...</summary>
    [JsonPropertyName("timestepAugmentation")]
    public double? TimestepAugmentation { get; set; }

}
