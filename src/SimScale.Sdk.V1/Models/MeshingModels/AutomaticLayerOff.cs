using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticLayerOff : OneOf_SimmetrixMeshingFluidAutomaticLayerSettings
{
    /// <summary>Schema name: AutomaticLayerOff</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_LAYER_OFF";

}
