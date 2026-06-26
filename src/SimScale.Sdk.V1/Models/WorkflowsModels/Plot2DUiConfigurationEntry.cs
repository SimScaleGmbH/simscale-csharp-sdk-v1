using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class Plot2DUiConfigurationEntry : UiConfigurationEntry
{
    [JsonPropertyName("configuration_entry_type")]
    [JsonRequired]
    public required string ConfigurationEntryType { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("dataSeries")]
    public JsonElement? DataSeries { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("groups")]
    public JsonElement? Groups { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("name")]
    public JsonElement? Name { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("xaxisLabel")]
    public JsonElement? XaxisLabel { get; set; }

    /// <summary>Value model for an enum value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("xaxisScale")]
    public JsonElement? XaxisScale { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("yaxisLabel")]
    public JsonElement? YaxisLabel { get; set; }

    /// <summary>Value model for an enum value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("yaxisScale")]
    public JsonElement? YaxisScale { get; set; }

}
