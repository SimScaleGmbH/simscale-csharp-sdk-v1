using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindTunnelSizeLarge : OneOf_AdvancedROISettingsWindTunnelSize
{
    /// <summary>Schema name: WindTunnelSizeLarge</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WIND_TUNNEL_SIZE_LARGE";

}
