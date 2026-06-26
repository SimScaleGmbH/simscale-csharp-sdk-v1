using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ReportFromStateRequest
{
    /// <summary>The name of the report.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The description of the report.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The IDs of the results for which the report should be created.</summary>
    [JsonPropertyName("resultIds")]
    [JsonRequired]
    public required List<Guid> ResultIds { get; set; }

    [JsonPropertyName("reportFromStateProperties")]
    [JsonRequired]
    public required ReportFromStateProperties ReportFromStateProperties { get; set; }

    /// <summary>If provided, the newly created report will have this value for its UUID.</summary>
    [JsonPropertyName("reportId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ReportId { get; set; }

    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }

}
