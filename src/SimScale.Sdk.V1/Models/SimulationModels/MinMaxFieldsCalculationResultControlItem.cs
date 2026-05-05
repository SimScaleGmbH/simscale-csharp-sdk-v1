using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MinMaxFieldsCalculationResultControlItem : OneOf_SolidResultControlEdgeCalculation, OneOf_SolidResultControlAreaCalculation, OneOf_SolidResultControlVolumeCalculation
{
    /// <summary>Schema name: MinMaxFieldsCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MIN_MAX_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
