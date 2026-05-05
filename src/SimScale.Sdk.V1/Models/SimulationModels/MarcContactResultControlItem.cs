using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcContactResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("contactType")]
    public OneOf_MarcContactResultControlItemContactType? ContactType { get; set; }

}
