using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewtonNonLinearityResolution : OneOf_ConnectionSettingsV36NonlinearityResolution
{
    /// <summary>Schema name: NewtonNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWTON";

    [JsonPropertyName("iterationCriterion")]
    public double? IterationCriterion { get; set; }

}
