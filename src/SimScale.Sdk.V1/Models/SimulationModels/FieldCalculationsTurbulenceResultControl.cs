using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsTurbulenceResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsTurbulenceResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public OneOf_FieldCalculationsTurbulenceResultControlResultType? ResultType { get; set; }

}
