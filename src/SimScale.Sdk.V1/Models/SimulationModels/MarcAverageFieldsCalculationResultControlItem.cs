using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcAverageFieldsCalculationResultControlItem : OneOf_MarcResultControlAreaCalculation, OneOf_MarcResultControlVolumeCalculation
{
    /// <summary>Schema name: MarcAverageFieldsCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AVERAGE_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
