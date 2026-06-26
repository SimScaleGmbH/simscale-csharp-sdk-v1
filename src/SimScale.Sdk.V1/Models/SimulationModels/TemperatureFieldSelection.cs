using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TemperatureFieldSelection : OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: TemperatureFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPERATURE";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
