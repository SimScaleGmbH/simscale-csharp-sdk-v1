using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify a floating potential on a boundary or a body for conductive bodies with a constant but unspecified voltage value.</summary>
public class FloatingPotential : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Specify a floating potential on a boundary or a body for conductive bodies with a constant but unspecified voltage va...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLOATING_POTENTIAL";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
