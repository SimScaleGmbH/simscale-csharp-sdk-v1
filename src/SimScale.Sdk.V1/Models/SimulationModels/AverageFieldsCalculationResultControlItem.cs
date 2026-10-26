using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Use Average to output the mean nodal value of the selected result quantity on the assigned entity. Note that this is not an area weighted average and that the nodal values from large elements will have the same contribution as those from small elements meaning that results can be misleading when mesh size varies on the selected entity.</summary>
public class AverageFieldsCalculationResultControlItem : OneOf_SolidResultControlEdgeCalculation, OneOf_SolidResultControlAreaCalculation, OneOf_SolidResultControlVolumeCalculation
{
    /// <summary>Use Average to output the mean nodal value of the selected result quantity on the assigned entity. Note that this is...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AVERAGE_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_AverageFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
