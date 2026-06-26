using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>A progress entry from the method engine.</summary>
public class MethodProgressEntry
{
    [JsonPropertyName("checkpoint")]
    public JsonElement? Checkpoint { get; set; }

    [JsonPropertyName("percentage")]
    public JsonElement? Percentage { get; set; }

}
