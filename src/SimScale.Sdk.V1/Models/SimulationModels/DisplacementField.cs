using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select the field which should have a limited de-/increase within one increment.</summary>
public class DisplacementField : OneOf_FieldChangeRetimingEventFieldSelection
{
    /// <summary>Select the field which should have a limited de-/increase within one increment. Schema name: DisplacementField</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENT";

    /// <summary>Choose a field component for which the data schould be extracted.</summary>
    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
