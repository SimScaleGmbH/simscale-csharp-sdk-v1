using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FindGapsParameters
{
    [JsonPropertyName("maxSize")]
    [JsonRequired]
    public required Length MaxSize { get; set; }

    [JsonPropertyName("minSize")]
    [JsonRequired]
    public required Length MinSize { get; set; }

    /// <summary>Maximum allowed angle between the normals of the opposing gap faces. Allowed values are between 0 and 90 degrees.</summary>
    [JsonPropertyName("maxAngle")]
    [JsonRequired]
    public required double MaxAngle { get; set; }

}
