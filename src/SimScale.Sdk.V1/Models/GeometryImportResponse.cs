using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class GeometryImportResponse
{
    /// <summary>The ID of the geometry import operation.</summary>
    [JsonPropertyName("geometryImportId")]
    [JsonRequired]
    public required Guid GeometryImportId { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public required string Status { get; set; }

    /// <summary>The ID of the imported geometry when the import succeeded.</summary>
    [JsonPropertyName("geometryId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid GeometryId { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
