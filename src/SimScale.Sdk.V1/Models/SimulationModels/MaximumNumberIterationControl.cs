using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MaximumNumberIterationControl : OneOf_FixedPointContactNonLinearityResolutionIterationControl
{
    /// <summary>Schema name: MaximumNumberIterationControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAXIMUM_NUMBER";

    [JsonPropertyName("maxNumIteration")]
    public int? MaxNumIteration { get; set; }

}
