using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedPointNonLinearityResolution : OneOf_ConnectionSettingsV36NonlinearityResolution
{
    /// <summary>Schema name: FixedPointNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_POINT";

    [JsonPropertyName("geometryReactualization")]
    public OneOf_FixedPointNonLinearityResolutionGeometryReactualization? GeometryReactualization { get; set; }

}
