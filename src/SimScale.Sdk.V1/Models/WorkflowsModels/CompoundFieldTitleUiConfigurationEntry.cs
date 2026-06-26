using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class CompoundFieldTitleUiConfigurationEntry : UiConfigurationEntry
{
    [JsonPropertyName("configuration_entry_type")]
    [JsonRequired]
    public required string ConfigurationEntryType { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    /// <summary>Value model for an enum value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("titleType")]
    public JsonElement? TitleType { get; set; }

}
