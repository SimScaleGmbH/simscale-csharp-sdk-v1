using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VelocityResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: VelocityResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VELOCITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("velocityType")]
    public GlobalVelocityType? VelocityType { get; set; }

}
