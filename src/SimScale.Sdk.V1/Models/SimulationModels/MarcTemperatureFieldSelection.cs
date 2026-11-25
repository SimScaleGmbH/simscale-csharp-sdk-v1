using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcTemperatureFieldSelection : OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection, OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcTemperatureFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPERATURE";

    [JsonPropertyName("temperatureType")]
    public MarcGlobalTemperatureFieldType? TemperatureType { get; set; }

}
