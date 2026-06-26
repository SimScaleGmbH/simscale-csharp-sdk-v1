using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class CompoundFieldCustomUiConfigurationEntry : UiConfigurationEntry
{
    [JsonPropertyName("configuration_entry_type")]
    [JsonRequired]
    public required string ConfigurationEntryType { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    /// <summary>Value model for a concrete compound value. Resolves to an object JSON node. Note that the serialized representation o...</summary>
    [JsonPropertyName("customUiConfigurationValue")]
    public JsonElement? CustomUiConfigurationValue { get; set; }

}
