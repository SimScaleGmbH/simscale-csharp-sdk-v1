using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.CadModels;

namespace SimScale.Sdk.V1.Models;

public class CadQueryResponse
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("result")]
    public JsonElement? Result { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
