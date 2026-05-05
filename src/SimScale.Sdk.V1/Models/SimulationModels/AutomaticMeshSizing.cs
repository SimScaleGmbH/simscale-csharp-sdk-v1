using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticMeshSizing : OneOf_NewRegionRefinementPacefishV38MeshSizing, OneOf_NewSurfaceRefinementPacefishV38MeshSizing
{
    /// <summary>Schema name: AutomaticMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

    /// <summary>Choose between Automatic and Manual mesh settings. Learn more.Note: Mesh fineness impacts the accuracy of your result...</summary>
    [JsonPropertyName("fineness")]
    public string? Fineness { get; set; }

}
