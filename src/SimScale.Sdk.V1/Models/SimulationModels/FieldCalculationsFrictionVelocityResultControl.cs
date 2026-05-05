using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsFrictionVelocityResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsFrictionVelocityResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_VELOCITY_U_TAU";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public FrictionVelocityResultType? ResultType { get; set; }

}
