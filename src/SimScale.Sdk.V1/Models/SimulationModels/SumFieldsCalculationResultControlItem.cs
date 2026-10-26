using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Use Sum to output the sum of the nodal values of the selected result quantity on the assigned entity. This option is only available for use with force solution fields and must be used when computing any force e.g. reaction force on a selected entity.</summary>
public class SumFieldsCalculationResultControlItem : OneOf_SolidResultControlEdgeCalculation, OneOf_SolidResultControlAreaCalculation, OneOf_SolidResultControlVolumeCalculation
{
    /// <summary>Use Sum to output the sum of the nodal values of the selected result quantity on the assigned entity. This option is...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUM_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_SumFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
