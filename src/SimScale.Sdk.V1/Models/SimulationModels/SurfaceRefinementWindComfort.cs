using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceRefinementWindComfort : OneOf_WindComfortMeshRefinements
{
    /// <summary>Schema name: SurfaceRefinementWindComfort</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_REFINEMENT_WIND_COMFORT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("newFineness")]
    public OneOf_SurfaceRefinementWindComfortNewFineness? NewFineness { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
