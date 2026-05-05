using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsTotalTIResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsTotalTIResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_TURBULENCE_INTENSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public TotalTurbulenceIntensity? ResultType { get; set; }

}
