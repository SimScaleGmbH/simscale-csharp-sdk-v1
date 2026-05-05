using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsResolvedTKEResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsResolvedTKEResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESOLVED_TURBULENT_KINETIC_ENERGY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public ResolvedTurbulentKineticEnergy? ResultType { get; set; }

}
