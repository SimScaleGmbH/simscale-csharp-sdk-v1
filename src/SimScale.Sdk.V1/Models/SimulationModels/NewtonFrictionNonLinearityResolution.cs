using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewtonFrictionNonLinearityResolution : OneOf_CoulombFrictionNonlinearityResolution
{
    /// <summary>Schema name: NewtonFrictionNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWTON_V29";

    [JsonPropertyName("iterationCriterion")]
    public double? IterationCriterion { get; set; }

}
