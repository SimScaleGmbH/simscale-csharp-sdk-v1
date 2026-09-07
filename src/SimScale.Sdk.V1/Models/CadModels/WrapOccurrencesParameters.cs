using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class WrapOccurrencesParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    /// <summary>Defines the behavior of the wrapper. It can be either: - `features` (shown in the UI as "Snap to edges"): to try to p...</summary>
    [JsonPropertyName("wrap_type")]
    [JsonRequired]
    public required string WrapType { get; set; }

    /// <summary>Resolution of the wrapper, the higher the resolution, the closer the result would be to the selected volumes. Must be...</summary>
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

    /// <summary>Controls whether the selected occurrences are wrapped individually or merged into a single wrap body. In both cases,...</summary>
    [JsonPropertyName("replace_each")]
    [JsonRequired]
    public required bool ReplaceEach { get; set; }

}
