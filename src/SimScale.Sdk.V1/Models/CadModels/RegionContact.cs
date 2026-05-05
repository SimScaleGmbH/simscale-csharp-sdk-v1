using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class RegionContact
{
    /// <summary>Internal name of the solid region.</summary>
    [JsonPropertyName("regionA")]
    [JsonRequired]
    public required string RegionA { get; set; }

    /// <summary>Internal name of the solid region.</summary>
    [JsonPropertyName("regionB")]
    [JsonRequired]
    public required string RegionB { get; set; }

    /// <summary>List of faces in contact.</summary>
    [JsonPropertyName("faceContacts")]
    [JsonRequired]
    public required List<FaceContact> FaceContacts { get; set; }

}
