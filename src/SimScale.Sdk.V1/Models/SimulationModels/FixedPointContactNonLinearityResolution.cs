using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedPointContactNonLinearityResolution : OneOf_ConnectionSettingsV36ContactNonLinearityResolution
{
    /// <summary>Schema name: FixedPointContactNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_POINT";

    [JsonPropertyName("iterationControl")]
    public OneOf_FixedPointContactNonLinearityResolutionIterationControl? IterationControl { get; set; }

}
