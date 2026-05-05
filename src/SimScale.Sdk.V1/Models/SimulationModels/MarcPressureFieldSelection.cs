using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcPressureFieldSelection : OneOf_MarcAverageFieldsCalculationResultControlItemFieldSelection, OneOf_MarcMinMaxFieldsCalculationResultControlItemFieldSelection
{
    /// <summary>Schema name: MarcPressureFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

    [JsonPropertyName("pressureType")]
    public MarcExternalPressureType? PressureType { get; set; }

}
