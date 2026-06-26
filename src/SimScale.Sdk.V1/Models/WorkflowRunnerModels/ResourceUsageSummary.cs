using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Resource usage split into total, chargeable, and non-chargeable parts.</summary>
public class ResourceUsageSummary
{
    [JsonPropertyName("chargeable")]
    public ResourceUsage? Chargeable { get; set; }

    [JsonPropertyName("nonChargeable")]
    public ResourceUsage? NonChargeable { get; set; }

    [JsonPropertyName("total")]
    public ResourceUsage? Total { get; set; }

}
