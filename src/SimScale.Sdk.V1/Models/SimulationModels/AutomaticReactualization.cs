using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticReactualization : OneOf_FixedPointNonLinearityResolutionGeometryReactualization
{
    /// <summary>Schema name: AutomaticReactualization</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

    [JsonPropertyName("maxNumIterations")]
    public int? MaxNumIterations { get; set; }

    [JsonPropertyName("iterationCriterion")]
    public double? IterationCriterion { get; set; }

}
