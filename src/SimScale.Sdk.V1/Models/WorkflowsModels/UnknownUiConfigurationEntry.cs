using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class UnknownUiConfigurationEntry : UiConfigurationEntry
{
    [JsonPropertyName("configuration_entry_type")]
    [JsonRequired]
    public required string ConfigurationEntryType { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

}
