using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FaceNormalMagnetizationDirectionMethod : OneOf_PermanentMagnetMaterialMagnetizationDirectionType
{
    /// <summary>Schema name: FaceNormalMagnetizationDirectionMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FACE_NORMAL";

    [JsonPropertyName("magnetFaces")]
    public TopologicalReference? MagnetFaces { get; set; }

}
