using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MoveFacesParameters
{
    /// <summary>List of faces.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    [JsonPropertyName("move_method")]
    [JsonRequired]
    public required MoveFacesGroupParameter MoveMethod { get; set; }

}
