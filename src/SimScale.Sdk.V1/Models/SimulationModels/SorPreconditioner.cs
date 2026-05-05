using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SorPreconditioner : OneOf_AdvancedPETSCSettingsPreconditioner
{
    /// <summary>Schema name: SorPreconditioner</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SOR";

    /// <summary>Choose the renumbering method for the system matrix entries:RCMK uses the algorithm of Reverse Cuthill-MacKee for the...</summary>
    [JsonPropertyName("renumberingMethod")]
    public string? RenumberingMethod { get; set; }

}
