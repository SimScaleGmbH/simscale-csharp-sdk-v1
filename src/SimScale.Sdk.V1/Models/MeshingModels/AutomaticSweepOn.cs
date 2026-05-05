using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticSweepOn : OneOf_SimmetrixMeshingSolidAutomaticSweepParameters, OneOf_SimmetrixMeshingFluidAutomaticSweepParameters
{
    /// <summary>Schema name: AutomaticSweepOn</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_SWEEP_MESHING_ON";

    [JsonPropertyName("maximumNumberOfLayers")]
    public int? MaximumNumberOfLayers { get; set; }

    [JsonPropertyName("minimumNumberOfLayers")]
    public int? MinimumNumberOfLayers { get; set; }

    [JsonPropertyName("surfaceElementType")]
    public string? SurfaceElementType { get; set; }

    /// <summary>If a part can be extruded along multiple directions, choose whether to extrude along the shortest or the longest dire...</summary>
    [JsonPropertyName("extrusionDirection")]
    public string? ExtrusionDirection { get; set; }

}
