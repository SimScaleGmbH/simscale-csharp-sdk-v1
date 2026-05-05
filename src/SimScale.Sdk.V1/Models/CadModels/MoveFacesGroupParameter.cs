using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MoveFacesGroupParameter
{
    /// <summary>Defines the parameter set used to define the extrusion. It can be either: - `move_faces_mode_distance`, in which case...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("move_distance")]
    public Length? MoveDistance { get; set; }

    /// <summary>Face limiting the move.</summary>
    [JsonPropertyName("move_up_to_face")]
    public string? MoveUpToFace { get; set; }

}
