using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ScalingEstimationValueModel
{
    [JsonPropertyName("gpuScaling")]
    public GpuScalingEstimationValueModel? GpuScaling { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("memory")]
    public JsonElement? Memory { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("speedUp")]
    public JsonElement? SpeedUp { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("storage")]
    public JsonElement? Storage { get; set; }

}
