using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewSurfaceRefinementPacefishV38 : OneOf_PacefishAutomeshRefinements
{
    /// <summary>Schema name: NewSurfaceRefinementPacefishV38</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_PACEFISH_V38";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("meshSizing")]
    public OneOf_NewSurfaceRefinementPacefishV38MeshSizing? MeshSizing { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
