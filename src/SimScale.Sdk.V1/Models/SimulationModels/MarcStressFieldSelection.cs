using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcStressFieldSelection : OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection, OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcStressFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRESS";

    [JsonPropertyName("stressType")]
    public OneOf_MarcStressFieldSelectionStressType? StressType { get; set; }

}
