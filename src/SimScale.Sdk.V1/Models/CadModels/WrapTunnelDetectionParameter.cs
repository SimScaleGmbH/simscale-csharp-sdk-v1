using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class WrapTunnelDetectionParameter
{
    /// <summary>Defines the method to detect tunnels in the input bodies. It can be either: - `wrap_surface_tunnel_detection_manual`,...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("min_tunnel_diameter")]
    public Length? MinTunnelDiameter { get; set; }

}
