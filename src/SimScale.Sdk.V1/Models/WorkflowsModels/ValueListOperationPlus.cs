using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ValueListOperationPlus : ValueList, ValueListDataSeriesValue, ValueListEnumValue, ValueListIntegerValue, ValueListRealValue, ValueListScalingPointValueModel, ValueListStringValue, ValueListTimeByArchValueModel, ValueListTimeByGpuArchAndModelValueModel, ValueListTimeByGpuArchValueModel, ValueListValue
{
    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("operandA")]
    public JsonElement? OperandA { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
