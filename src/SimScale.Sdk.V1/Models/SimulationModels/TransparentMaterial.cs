using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TransparentMaterial : OneOf_SolidCompressibleMaterialRadiativeBehavior
{
    /// <summary>Schema name: TransparentMaterial</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRANSPARENT_MATERIAL";

}
