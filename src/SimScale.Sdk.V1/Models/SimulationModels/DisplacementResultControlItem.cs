using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DisplacementResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: DisplacementResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacementType")]
    public GlobalDisplacementType? DisplacementType { get; set; }

}
