using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The magnetic field is enforced to be perpendicular to the boundary.</summary>
public class MagneticFieldNormal : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>The magnetic field is enforced to be perpendicular to the boundary. Schema name: MagneticFieldNormal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAGNETIC_FIELD_NORMAL";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
