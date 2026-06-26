using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Resource usage amount in core-seconds.</summary>
public class ResourceUsage
{
    [JsonPropertyName("cpuCoreSeconds")]
    public long? CpuCoreSeconds { get; set; }

    [JsonPropertyName("gpuCoreSeconds")]
    public long? GpuCoreSeconds { get; set; }

}
