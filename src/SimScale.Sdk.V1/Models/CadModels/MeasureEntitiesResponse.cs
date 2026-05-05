using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MeasureEntitiesResponse
{
    /// <summary>Message describing the measure.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Measure results.</summary>
    [JsonPropertyName("measured")]
    public List<MeasuredValue>? Measured { get; set; }

}
