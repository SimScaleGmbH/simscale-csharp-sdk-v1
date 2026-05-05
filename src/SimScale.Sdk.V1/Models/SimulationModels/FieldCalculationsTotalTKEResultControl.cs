using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsTotalTKEResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsTotalTKEResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_TURBULENT_KINETIC_ENERGY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public TotalTurbulentKineticEnergy? ResultType { get; set; }

}
