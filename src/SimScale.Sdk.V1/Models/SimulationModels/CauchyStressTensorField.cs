using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select the field which should have a limited de-/increase within one increment.</summary>
public class CauchyStressTensorField : OneOf_FieldChangeRetimingEventFieldSelection
{
    /// <summary>Select the field which should have a limited de-/increase within one increment. Schema name: CauchyStressTensorField</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CAUCHY_STRESS_TENSOR";

    /// <summary>Choose a field component for which the data schould be extracted.</summary>
    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
