using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AverageFieldsCalculationResultControlItem : OneOf_SolidResultControlEdgeCalculation, OneOf_SolidResultControlAreaCalculation, OneOf_SolidResultControlVolumeCalculation
{
    /// <summary>Schema name: AverageFieldsCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AVERAGE_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_AverageFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
