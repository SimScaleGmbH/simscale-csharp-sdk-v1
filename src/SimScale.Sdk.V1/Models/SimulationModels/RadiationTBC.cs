using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RadiationTBC : OneOf_WallBCTemperature
{
    /// <summary>Schema name: RadiationTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RADIATIVE_HEAT_TRANSFER";

    [JsonPropertyName("radiation")]
    public WallRadiationModel? Radiation { get; set; }

}
