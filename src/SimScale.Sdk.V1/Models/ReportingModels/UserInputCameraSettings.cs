using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class UserInputCameraSettings : OneOfCameraSettings
{
    [JsonPropertyName("settingType")]
    public string SettingType { get; set; } = "USER_INPUT";

    [JsonPropertyName("projectionType")]
    [JsonRequired]
    public required string ProjectionType { get; set; }

    [JsonPropertyName("up")]
    [JsonRequired]
    public required Vector3D Up { get; set; }

    [JsonPropertyName("eye")]
    [JsonRequired]
    public required Vector3D Eye { get; set; }

    [JsonPropertyName("center")]
    [JsonRequired]
    public required Vector3D Center { get; set; }

    /// <summary>required only for orthogonal projection type.</summary>
    [JsonPropertyName("frontPlaneFrustumHeight")]
    public double? FrontPlaneFrustumHeight { get; set; }

    /// <summary>The total field of view in Y direction in degrees. Required onlyf for perspective projection type.</summary>
    [JsonPropertyName("fieldOfViewYDegrees")]
    public double? FieldOfViewYDegrees { get; set; }

}
