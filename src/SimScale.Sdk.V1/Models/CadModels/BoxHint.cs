using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Hint box in meters to be used in the viewer.</summary>
public class BoxHint
{
    [JsonPropertyName("min")]
    [JsonRequired]
    public required Vector Min { get; set; }

    [JsonPropertyName("max")]
    [JsonRequired]
    public required Vector Max { get; set; }

}
