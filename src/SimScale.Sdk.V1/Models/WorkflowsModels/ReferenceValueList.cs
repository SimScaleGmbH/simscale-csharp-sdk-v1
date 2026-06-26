using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ReferenceValueList : ValueList, ValueListDataSeriesValue, ValueListEnumValue, ValueListIntegerValue, ValueListRealValue, ValueListScalingPointValueModel, ValueListStringValue, ValueListTimeByArchValueModel, ValueListTimeByGpuArchAndModelValueModel, ValueListTimeByGpuArchValueModel, ValueListValue
{
    [JsonPropertyName("defaultValue")]
    public List<Dictionary<string, JsonElement>>? DefaultValue { get; set; }

    [JsonPropertyName("elementModel")]
    public Value? ElementModel { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
