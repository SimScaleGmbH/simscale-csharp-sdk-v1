using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AccelerationResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: AccelerationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ACCELERATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("accelerationType")]
    public GlobalAccelerationType? AccelerationType { get; set; }

}
