using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ValueListFunctionTableSection : ValueList, ValueListDataSeriesValue, ValueListEnumValue, ValueListIntegerValue, ValueListRealValue, ValueListScalingPointValueModel, ValueListStringValue, ValueListTimeByArchValueModel, ValueListTimeByGpuArchAndModelValueModel, ValueListTimeByGpuArchValueModel, ValueListValue
{
    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("at")]
    public JsonElement? At { get; set; }

    [JsonPropertyName("elementModel")]
    public Value? ElementModel { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("holdAboveRange")]
    public JsonElement? HoldAboveRange { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("holdBelowRange")]
    public JsonElement? HoldBelowRange { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("logarithmic")]
    public JsonElement? Logarithmic { get; set; }

    [JsonPropertyName("parameterColumn")]
    public string? ParameterColumn { get; set; }

    [JsonPropertyName("quantityColumn")]
    public string? QuantityColumn { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("stepwise")]
    public JsonElement? Stepwise { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("valueList")]
    public JsonElement? ValueList { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
