using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CalculateFrequency
{
    [JsonPropertyName("precShift")]
    public double? PrecShift { get; set; }

    [JsonPropertyName("maxIterShift")]
    public int? MaxIterShift { get; set; }

    [JsonPropertyName("thresholdFrequency")]
    public double? ThresholdFrequency { get; set; }

}
