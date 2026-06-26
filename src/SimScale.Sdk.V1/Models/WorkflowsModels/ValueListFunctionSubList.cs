using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ValueListFunctionSubList : ValueList, ValueListDataSeriesValue, ValueListEnumValue, ValueListIntegerValue, ValueListRealValue, ValueListScalingPointValueModel, ValueListStringValue, ValueListTimeByArchValueModel, ValueListTimeByGpuArchAndModelValueModel, ValueListTimeByGpuArchValueModel, ValueListValue
{
    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("from")]
    public JsonElement? From { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("to")]
    public JsonElement? To { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("valueList")]
    public JsonElement? ValueList { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
