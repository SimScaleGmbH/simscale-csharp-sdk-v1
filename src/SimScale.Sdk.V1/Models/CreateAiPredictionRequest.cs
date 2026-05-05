using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateAiPredictionRequest
{
    [JsonPropertyName("aiModelId")]
    [JsonRequired]
    public required Guid AiModelId { get; set; }

    [JsonPropertyName("projectId")]
    [JsonRequired]
    public required string ProjectId { get; set; }

    [JsonPropertyName("simulationId")]
    [JsonRequired]
    public required Guid SimulationId { get; set; }

}
