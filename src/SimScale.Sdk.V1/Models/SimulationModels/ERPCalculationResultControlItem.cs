using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ERPCalculationResultControlItem : OneOf_SolidResultControlAreaCalculation
{
    /// <summary>Schema name: ERPCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ERP_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_ERPCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
