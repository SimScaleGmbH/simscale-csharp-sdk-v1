using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class AutomaticStateMetadata : StateMetadata
{
    [JsonPropertyName("stateType")]
    public string StateType { get; set; } = "AUTOMATIC";

    /// <summary>The UUID of the specific state (Mandatory for AUTOMATIC/MANUAL).</summary>
    [JsonPropertyName("stateUuid")]
    [JsonRequired]
    public required Guid StateUuid { get; set; }

}
