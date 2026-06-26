using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.WorkflowsModels;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>One particular case of a validation rule to be checked during validation.</summary>
public class ValidationRuleCase
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("condition")]
    public BooleanValue? Condition { get; set; }

    [JsonPropertyName("details")]
    public Dictionary<string, JsonElement>? Details { get; set; }

    [JsonPropertyName("message")]
    public StringValue? Message { get; set; }

    [JsonPropertyName("multiLanguageMessage")]
    public Dictionary<string, StringValue>? MultiLanguageMessage { get; set; }

    /// <summary>Severity levels for reporting validation results.</summary>
    [JsonPropertyName("severityLevel")]
    public string? SeverityLevel { get; set; }

}
