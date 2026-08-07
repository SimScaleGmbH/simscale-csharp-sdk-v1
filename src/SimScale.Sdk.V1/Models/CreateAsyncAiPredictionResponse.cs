using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateAsyncAiPredictionResponse
{
    [JsonPropertyName("predictionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid PredictionId { get; set; }

    /// <summary>RUNNING - Prediction is in progress, poll GET /ai/predictions/{predictionId} for the results</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

}
