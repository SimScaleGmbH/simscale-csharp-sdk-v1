using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class AvailableAiModel
{
    [JsonPropertyName("aiModelLabel")]
    public string? AiModelLabel { get; set; }

    [JsonPropertyName("aiModelId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid AiModelId { get; set; }

}
