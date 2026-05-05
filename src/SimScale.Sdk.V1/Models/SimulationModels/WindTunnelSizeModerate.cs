using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindTunnelSizeModerate : OneOf_AdvancedROISettingsWindTunnelSize
{
    /// <summary>Schema name: WindTunnelSizeModerate</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WIND_TUNNEL_SIZE_MODERATE";

}
