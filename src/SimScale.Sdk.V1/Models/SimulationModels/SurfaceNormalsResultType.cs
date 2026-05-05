using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceNormalsResultType
{
    /// <summary>Schema name: SurfaceNormalsResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_NORMALS";

}
