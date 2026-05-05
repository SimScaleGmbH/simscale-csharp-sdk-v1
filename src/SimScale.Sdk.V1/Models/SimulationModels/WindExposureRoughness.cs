using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindExposureRoughness : OneOf_SurfaceRoughnessModelSurfaceRoughnessType
{
    /// <summary>Schema name: WindExposureRoughness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WIND_EXPOSURE_ROUGHNESS";

}
