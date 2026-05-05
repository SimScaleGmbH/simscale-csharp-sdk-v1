using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify a constant electric potential (voltage) on a boundary or a body.</summary>
public class FixedPotential : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Specify a constant electric potential (voltage) on a boundary or a body. Schema name: FixedPotential</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_POTENTIAL";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("potential")]
    public Dimensional_ElectricPotential? Potential { get; set; }

    [JsonPropertyName("potentialRMS")]
    public Dimensional_ElectricPotential? PotentialRMS { get; set; }

    [JsonPropertyName("phase")]
    public Dimensional_Angle? Phase { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
