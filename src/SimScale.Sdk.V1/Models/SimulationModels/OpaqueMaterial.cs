using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OpaqueMaterial : OneOf_SolidCompressibleMaterialRadiativeBehavior
{
    /// <summary>Schema name: OpaqueMaterial</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OPAQUE_MATERIAL";

    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

}
