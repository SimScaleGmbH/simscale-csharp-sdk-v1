using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class MeasurementUnitExpressionSelect : MeasurementUnitValue
{
    [JsonPropertyName("options")]
    public List<Dictionary<string, JsonElement>>? Options { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
