using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedPointFrictionNonLinearityResolution : OneOf_CoulombFrictionNonlinearityResolution
{
    /// <summary>Schema name: FixedPointFrictionNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_POINT";

    [JsonPropertyName("maxNumIteration")]
    public int? MaxNumIteration { get; set; }

    [JsonPropertyName("iterationCriterion")]
    public double? IterationCriterion { get; set; }

}
