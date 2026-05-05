using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class TopViewPredefinedCameraSettings : OneOfCameraSettings
{
    [JsonPropertyName("settingType")]
    public string SettingType { get; set; } = "TOP_VIEW";

    [JsonPropertyName("projectionType")]
    [JsonRequired]
    public required string ProjectionType { get; set; }

    [JsonPropertyName("directionSpecifier")]
    [JsonRequired]
    public required string DirectionSpecifier { get; set; }

}
