using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class OneProcessorEstimationValueModel
{
    [JsonPropertyName("gpuEstimation")]
    public OneGpuEstimationValueModel? GpuEstimation { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("memoryInMebibytes")]
    public JsonElement? MemoryInMebibytes { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("storageInMebibytes")]
    public JsonElement? StorageInMebibytes { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("timeInSeconds")]
    public JsonElement? TimeInSeconds { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("timeInSecondsByArch")]
    public JsonElement? TimeInSecondsByArch { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("timeInSecondsByGpuArch")]
    public JsonElement? TimeInSecondsByGpuArch { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("timeInSecondsByGpuArchAndModel")]
    public JsonElement? TimeInSecondsByGpuArchAndModel { get; set; }

}
