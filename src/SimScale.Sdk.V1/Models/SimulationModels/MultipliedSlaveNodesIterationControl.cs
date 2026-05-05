using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MultipliedSlaveNodesIterationControl : OneOf_FixedPointContactNonLinearityResolutionIterationControl
{
    /// <summary>Schema name: MultipliedSlaveNodesIterationControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTIPLIED_SLAVE_NODE";

    [JsonPropertyName("multipleValue")]
    public int? MultipleValue { get; set; }

}
