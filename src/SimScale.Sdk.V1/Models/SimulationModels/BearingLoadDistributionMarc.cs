using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BearingLoadDistributionMarc
{
    /// <summary>Total angle of the cylindrical face over which the load is spread. The sector is centred symmetrically on the force d...</summary>
    [JsonPropertyName("angle")]
    public double? Angle { get; set; }

    /// <summary>How the load intensity varies across the loaded sector. The peak is at the force direction and the nodal forces alway...</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Direction of the forces applied at each node of the loaded sector. Both options produce the same resultant.Radial (de...</summary>
    [JsonPropertyName("orientation")]
    public string? Orientation { get; set; }

    /// <summary>Which side of the face is loaded and whether forces push away from or toward the cylinder axis. Choose based on which...</summary>
    [JsonPropertyName("distribution")]
    public string? Distribution { get; set; }

}
