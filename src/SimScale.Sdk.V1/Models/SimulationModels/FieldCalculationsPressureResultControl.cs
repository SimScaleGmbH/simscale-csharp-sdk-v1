using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsPressureResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsPressureResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressureType")]
    public OneOf_FieldCalculationsPressureResultControlPressureType? PressureType { get; set; }

    [JsonPropertyName("resultType")]
    public OneOf_FieldCalculationsPressureResultControlResultType? ResultType { get; set; }

}
