using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class WrapOccurrencesParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    /// <summary>Defines the behavior of the wrapper. It can be either: - `features`: to try preserve the edges of the selected volume...</summary>
    [JsonPropertyName("wrap_type")]
    [JsonRequired]
    public required string WrapType { get; set; }

    /// <summary>Resolution of the wrapper, the higher the resolution, the closer the result would be to the selected volumes. This va...</summary>
    [JsonPropertyName("resolution")]
    [JsonRequired]
    public required double Resolution { get; set; }

    /// <summary>Defines the behavior with respect to tunnels in the selected bodies. If `true`, the wrapper will attempt to go throug...</summary>
    [JsonPropertyName("allow_tunnels")]
    [JsonRequired]
    public required bool AllowTunnels { get; set; }

    /// <summary>Defines the behavior with respect to tunnels in the selected bodies. If `true`, the wrapper will create patches to co...</summary>
    [JsonPropertyName("cap_tunnels")]
    [JsonRequired]
    public required bool CapTunnels { get; set; }

    [JsonPropertyName("tunnel_detection")]
    [JsonRequired]
    public required WrapTunnelDetectionParameter TunnelDetection { get; set; }

    /// <summary>Controls the result. If `true`, each body will be replaced singularly; otherwise all bodies will be replaced by a sin...</summary>
    [JsonPropertyName("replace_each")]
    [JsonRequired]
    public required bool ReplaceEach { get; set; }

}
