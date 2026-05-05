using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindTunnelSizeCustom : OneOf_AdvancedROISettingsWindTunnelSize
{
    /// <summary>Schema name: WindTunnelSizeCustom</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WIND_TUNNEL_SIZE_CUSTOM";

    [JsonPropertyName("heightExtension")]
    public Dimensional_Length? HeightExtension { get; set; }

    [JsonPropertyName("sideExtension")]
    public Dimensional_Length? SideExtension { get; set; }

    [JsonPropertyName("inflowExtension")]
    public Dimensional_Length? InflowExtension { get; set; }

    [JsonPropertyName("outflowExtension")]
    public Dimensional_Length? OutflowExtension { get; set; }

}
