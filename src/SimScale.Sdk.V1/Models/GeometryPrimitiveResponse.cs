using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class GeometryPrimitiveResponse
{
    /// <summary>The ID of the created geometry primitive.</summary>
    [JsonPropertyName("geometryPrimitiveId")]
    [JsonRequired]
    public required Guid GeometryPrimitiveId { get; set; }

}
