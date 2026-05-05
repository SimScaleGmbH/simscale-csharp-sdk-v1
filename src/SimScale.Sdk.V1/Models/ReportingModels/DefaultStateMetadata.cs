using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class DefaultStateMetadata : StateMetadata
{
    [JsonPropertyName("stateType")]
    public string StateType { get; set; } = "DEFAULT";

    /// <summary>The analysis type (Mandatory for a DEFAULT state).</summary>
    [JsonPropertyName("stateAnalysisType")]
    [JsonRequired]
    public required string StateAnalysisType { get; set; }

}
