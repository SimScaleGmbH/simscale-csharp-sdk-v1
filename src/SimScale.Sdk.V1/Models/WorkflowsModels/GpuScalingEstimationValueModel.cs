using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class GpuScalingEstimationValueModel
{
    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("cpus")]
    public JsonElement? Cpus { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("gpuMemory")]
    public JsonElement? GpuMemory { get; set; }

}
