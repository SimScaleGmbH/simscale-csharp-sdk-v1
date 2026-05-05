using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ContactResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: ContactResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("contactType")]
    public string? ContactType { get; set; }

}
