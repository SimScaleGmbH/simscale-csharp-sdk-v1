using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class ExtrudeByParameter
{
    /// <summary>Defines the parameter set used to define the extrusion. It can be either: - `extrude_faces_mode_distance`, in which c...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("extrude_distance")]
    public Length? ExtrudeDistance { get; set; }

    /// <summary>Face limiting the extrusion.</summary>
    [JsonPropertyName("extrude_up_to_face")]
    public string? ExtrudeUpToFace { get; set; }

}
