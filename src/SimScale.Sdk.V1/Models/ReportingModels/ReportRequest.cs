using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A report on a simulation result, given as exactly one entry in resultIds, or on a standalone RAMPS result such as a dataflow output, given as its dataId. Exactly one of the two must be given; the service rejects requests with both or neither.</summary>
public class ReportRequest
{
    /// <summary>The name of the report.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The description of the report.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the simulation result for which the report is created. Exactly one entry, or empty when dataId is given.</summary>
    [JsonPropertyName("resultIds")]
    public List<Guid>? ResultIds { get; set; }

    /// <summary>The Data ID of the dataflow output for which the report is created. The data must belong to the project and reference...</summary>
    [JsonPropertyName("dataId")]
    public string? DataId { get; set; }

    [JsonPropertyName("reportProperties")]
    [JsonRequired]
    public required ReportProperties ReportProperties { get; set; }

    /// <summary>If provided, the newly created report will have this value for its UUID.</summary>
    [JsonPropertyName("reportId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ReportId { get; set; }

    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }

}
