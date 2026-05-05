using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateExportRequest
{
    /// <summary>The result to be exported</summary>
    [JsonPropertyName("resultId")]
    [JsonRequired]
    public required Guid ResultId { get; set; }

    /// <summary>The format to export to</summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public required string Format { get; set; }

}
