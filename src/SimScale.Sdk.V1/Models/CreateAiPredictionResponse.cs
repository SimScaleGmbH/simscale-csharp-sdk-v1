using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateAiPredictionResponse
{
    [JsonPropertyName("predictionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid PredictionId { get; set; }

    [JsonPropertyName("resultId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ResultId { get; set; }

    [JsonPropertyName("availableFields")]
    public List<JsonElement>? AvailableFields { get; set; }

    [JsonPropertyName("confidenceScore")]
    public double? ConfidenceScore { get; set; }

    [JsonPropertyName("globalOutputs")]
    public List<JsonElement>? GlobalOutputs { get; set; }

}
