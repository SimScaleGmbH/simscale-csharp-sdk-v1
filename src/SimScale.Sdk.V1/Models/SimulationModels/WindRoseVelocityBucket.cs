using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindRoseVelocityBucket
{
    [JsonPropertyName("from")]
    public double? From { get; set; }

    [JsonPropertyName("to")]
    public double? To { get; set; }

    [JsonPropertyName("fractions")]
    public List<double>? Fractions { get; set; }

}
