using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class MethodResourceEstimationValueModel
{
    [JsonPropertyName("oneProcessorEstimation")]
    public OneProcessorEstimationValueModel? OneProcessorEstimation { get; set; }

    [JsonPropertyName("scalingEstimation")]
    public ScalingEstimationValueModel? ScalingEstimation { get; set; }

}
