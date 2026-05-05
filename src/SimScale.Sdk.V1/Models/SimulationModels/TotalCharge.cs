using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Set the total charge of a body.</summary>
public class TotalCharge : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Set the total charge of a body. Schema name: TotalCharge</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_CHARGE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("totalCharge")]
    public Dimensional_Charge? TotalChargeValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
