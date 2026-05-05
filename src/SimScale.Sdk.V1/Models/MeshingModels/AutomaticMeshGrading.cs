using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticMeshGrading : OneOf_ManualMeshSizingGrading
{
    /// <summary>Schema name: AutomaticMeshGrading</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

    /// <summary>The mesh grading specifies how fine details of the geometry are resolved and also influences the quality of the resul...</summary>
    [JsonPropertyName("fineness")]
    public string? Fineness { get; set; }

}
