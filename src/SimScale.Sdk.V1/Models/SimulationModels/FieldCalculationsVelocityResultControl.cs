using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsVelocityResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsVelocityResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VELOCITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public VorticityResultType? ResultType { get; set; }

}
