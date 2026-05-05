using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Estimation
{
    [JsonPropertyName("duration")]
    public Duration? Duration { get; set; }

    [JsonPropertyName("computeResource")]
    public ComputeResource? ComputeResource { get; set; }

    [JsonPropertyName("cellCount")]
    public CellCount? CellCount { get; set; }

    /// <summary>The total number of jobs that will be triggered for this simulation run or mesh operation.</summary>
    [JsonPropertyName("totalRunCount")]
    public int? TotalRunCount { get; set; }

}
