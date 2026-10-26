using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>One particular case of a validation rule to be checked during validation.</summary>
public class ValidationRuleCase
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("condition")]
    public JsonElement? Condition { get; set; }

    [JsonPropertyName("details")]
    public Dictionary<string, Value>? Details { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("message")]
    public JsonElement? Message { get; set; }

    [JsonPropertyName("multiLanguageMessage")]
    public Dictionary<string, JsonElement>? MultiLanguageMessage { get; set; }

    /// <summary>Severity levels for reporting validation results.</summary>
    [JsonPropertyName("severityLevel")]
    public string? SeverityLevel { get; set; }

}
