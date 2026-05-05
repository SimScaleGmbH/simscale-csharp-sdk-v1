using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticLayerOn : OneOf_SimmetrixMeshingFluidAutomaticLayerSettings
{
    /// <summary>Schema name: AutomaticLayerOn</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_LAYER_ON";

    [JsonPropertyName("layerType")]
    public OneOf_AutomaticLayerOnLayerType? LayerType { get; set; }

}
