using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FaceContact
{
    /// <summary>Internal name of the face.</summary>
    [JsonPropertyName("faceA")]
    [JsonRequired]
    public required string FaceA { get; set; }

    /// <summary>Internal name of the face.</summary>
    [JsonPropertyName("faceB")]
    [JsonRequired]
    public required string FaceB { get; set; }

    /// <summary>Type of contact. It can be `PERFECT_FULL` when the faces' surfaces overlap perfectly within the modeller tolerance, `...</summary>
    [JsonPropertyName("contactType")]
    [JsonRequired]
    public required string ContactType { get; set; }

}
