using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class GeometryDerivationUiConfigurationEntry : UiConfigurationEntry
{
    [JsonPropertyName("configuration_entry_type")]
    [JsonRequired]
    public required string ConfigurationEntryType { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    /// <summary>How a point is derived from the geometry of assigned entities.</summary>
    [JsonPropertyName("derivation")]
    public string? Derivation { get; set; }

    [JsonPropertyName("sourceValueReference")]
    public ValueReference? SourceValueReference { get; set; }

}
