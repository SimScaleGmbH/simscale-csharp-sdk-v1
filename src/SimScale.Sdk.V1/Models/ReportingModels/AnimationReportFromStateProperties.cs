using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class AnimationReportFromStateProperties : ReportFromStateProperties
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "ANIMATION";

    [JsonPropertyName("stateMetadata")]
    [JsonRequired]
    public required StateMetadata StateMetadata { get; set; }

    [JsonPropertyName("outputSettings")]
    [JsonRequired]
    public required OneOfAnimationOutputSettings OutputSettings { get; set; }

}
