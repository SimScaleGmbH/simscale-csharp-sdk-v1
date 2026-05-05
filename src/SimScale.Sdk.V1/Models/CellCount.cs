using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>An interval with the estimated cell count of the generated mesh.</summary>
public class CellCount
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }

    [JsonPropertyName("intervalMin")]
    public long? IntervalMin { get; set; }

    [JsonPropertyName("intervalMax")]
    public long? IntervalMax { get; set; }

}
