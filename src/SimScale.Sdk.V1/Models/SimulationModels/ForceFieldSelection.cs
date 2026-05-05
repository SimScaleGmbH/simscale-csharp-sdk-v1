using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ForceFieldSelection : OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_SumFieldsCalculationResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: ForceFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE";

    [JsonPropertyName("forceType")]
    public OneOf_ForceFieldSelectionForceType? ForceType { get; set; }

}
