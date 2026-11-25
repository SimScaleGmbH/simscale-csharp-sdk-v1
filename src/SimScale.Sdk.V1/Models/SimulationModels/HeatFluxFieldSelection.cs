using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HeatFluxFieldSelection : OneOf_TemporalResponseResultControlItemFieldSelection, OneOf_AverageFieldsCalculationResultControlItemFieldSelection, OneOf_MinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: HeatFluxFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_FLUX";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
