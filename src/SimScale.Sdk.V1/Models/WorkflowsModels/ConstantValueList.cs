using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ConstantValueList : ValueList, ValueListDataSeriesValue, ValueListEnumValue, ValueListIntegerValue, ValueListRealValue, ValueListScalingPointValueModel, ValueListStringValue, ValueListTimeByArchValueModel, ValueListTimeByGpuArchAndModelValueModel, ValueListTimeByGpuArchValueModel, ValueListValue
{
    [JsonPropertyName("elementModel")]
    public Value? ElementModel { get; set; }

    [JsonPropertyName("values")]
    public List<Value>? Values { get; set; }

}
