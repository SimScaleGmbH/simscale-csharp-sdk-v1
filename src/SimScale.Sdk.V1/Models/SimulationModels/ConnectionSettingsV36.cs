using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConnectionSettingsV36
{
    [JsonPropertyName("nonlinearityResolution")]
    public OneOf_ConnectionSettingsV36NonlinearityResolution? NonlinearityResolution { get; set; }

    [JsonPropertyName("friction")]
    public OneOf_ConnectionSettingsV36Friction? Friction { get; set; }

    [JsonPropertyName("contactNonLinearityResolution")]
    public OneOf_ConnectionSettingsV36ContactNonLinearityResolution? ContactNonLinearityResolution { get; set; }

    [JsonPropertyName("convergenceStabilization")]
    public bool? ConvergenceStabilization { get; set; }

    [JsonPropertyName("contactSmoothing")]
    public bool? ContactSmoothing { get; set; }

}
