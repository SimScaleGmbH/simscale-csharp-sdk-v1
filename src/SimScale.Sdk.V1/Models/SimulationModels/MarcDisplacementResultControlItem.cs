using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcDisplacementResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcDisplacementResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacementType")]
    public GlobalDisplacement? DisplacementType { get; set; }

}
