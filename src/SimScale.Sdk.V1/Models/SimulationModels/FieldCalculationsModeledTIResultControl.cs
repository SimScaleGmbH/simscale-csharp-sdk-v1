using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsModeledTIResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsModeledTIResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MODELED_TURBULENCE_INTENSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public ModeledTurbulenceIntensity? ResultType { get; set; }

}
