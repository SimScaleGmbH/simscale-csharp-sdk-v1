using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcHeatFluxFieldSelection : OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection, OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcHeatFluxFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_FLUX";

    [JsonPropertyName("heatFluxType")]
    public MarcGlobalHeatFluxFieldType? HeatFluxType { get; set; }

}
