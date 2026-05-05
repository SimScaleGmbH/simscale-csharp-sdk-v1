using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric current enters or leaves the boundary.</summary>
public class MagneticFluxTangential : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric curr...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAGNETIC_FLUX_TANGENTIAL";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
