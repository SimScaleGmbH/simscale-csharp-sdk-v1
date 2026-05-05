using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class ExtrudeFacesParameters
{
    /// <summary>List of faces.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    /// <summary>The available extrude methods are: - `merge`: to merge the extrusion back to the original body, - `remove`: to extrud...</summary>
    [JsonPropertyName("extrude_method")]
    [JsonRequired]
    public required string ExtrudeMethod { get; set; }

    [JsonPropertyName("extrude_by")]
    [JsonRequired]
    public required ExtrudeByParameter ExtrudeBy { get; set; }

}
