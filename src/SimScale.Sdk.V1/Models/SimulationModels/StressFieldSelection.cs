using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StressFieldSelection : OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_HarmonicResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: StressFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRESS";

    [JsonPropertyName("stressType")]
    public OneOf_StressFieldSelectionStressType? StressType { get; set; }

}
