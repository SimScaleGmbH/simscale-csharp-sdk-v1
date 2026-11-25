using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Use Min-max to output the minimum and maximum nodal values of the selected result quantity on the assigned entity.</summary>
public class MinMaxFieldsCalculationResultControlItem : OneOf_SolidResultControlEdgeCalculation, OneOf_SolidResultControlAreaCalculation, OneOf_SolidResultControlVolumeCalculation
{
    /// <summary>Use Min-max to output the minimum and maximum nodal values of the selected result quantity on the assigned entity. Sc...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MIN_MAX_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The coordinate system in which the components of the selected field will be computed. Select from the available local...</summary>
    [JsonPropertyName("coordinateSystem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CoordinateSystem { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
