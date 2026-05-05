using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SemiTransparentMaterial : OneOf_SolidCompressibleMaterialRadiativeBehavior
{
    /// <summary>Schema name: SemiTransparentMaterial</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SEMI_TRANSPARENT_MATERIAL";

    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

    [JsonPropertyName("transmissivity")]
    public double? Transmissivity { get; set; }

}
