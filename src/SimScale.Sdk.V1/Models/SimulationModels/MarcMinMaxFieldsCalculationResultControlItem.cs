using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcMinMaxFieldsCalculationResultControlItem : OneOf_MarcResultControlAreaCalculation, OneOf_MarcResultControlVolumeCalculation
{
    /// <summary>Schema name: MarcMinMaxFieldsCalculationResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MIN_MAX_FIELDS_CALCULATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fieldSelection")]
    public OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection? FieldSelection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
