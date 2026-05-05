using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsResolvedTIResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsResolvedTIResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESOLVED_TURBULENCE_INTENSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public ResolvedTurbulenceIntensity? ResultType { get; set; }

}
