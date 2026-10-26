using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class Gap
{
    /// <summary>Solid region on one side of the gap.</summary>
    [JsonPropertyName("regionA")]
    [JsonRequired]
    public required string RegionA { get; set; }

    /// <summary>Faces on one side of the gap.</summary>
    [JsonPropertyName("facesA")]
    [JsonRequired]
    public required List<string> FacesA { get; set; }

    /// <summary>Solid region on another side of the gap.</summary>
    [JsonPropertyName("regionB")]
    [JsonRequired]
    public required string RegionB { get; set; }

    /// <summary>Faces on another side of the gap.</summary>
    [JsonPropertyName("facesB")]
    [JsonRequired]
    public required List<string> FacesB { get; set; }

    [JsonPropertyName("size")]
    [JsonRequired]
    public required Length Size { get; set; }

}
