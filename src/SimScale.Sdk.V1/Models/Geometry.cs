using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Geometry
{
    [JsonPropertyName("geometryId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid GeometryId { get; set; }

    /// <summary>The name of the geometry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time when the geometry was imported.</summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>The geometry format.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

}
