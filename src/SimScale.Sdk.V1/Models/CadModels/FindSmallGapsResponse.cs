using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FindSmallGapsResponse
{
    /// <summary>List of face pairs indicating a gap for the given tolerance.</summary>
    [JsonPropertyName("face_pairs")]
    [JsonRequired]
    public required List<FacePairs> FacePairs { get; set; }

}
