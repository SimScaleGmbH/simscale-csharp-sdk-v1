using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcForceResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcForceResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("forceType")]
    public OneOf_MarcForceResultControlItemForceType? ForceType { get; set; }

}
