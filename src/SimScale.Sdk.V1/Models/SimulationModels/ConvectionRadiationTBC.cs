using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConvectionRadiationTBC : OneOf_WallBCTemperature
{
    /// <summary>Schema name: ConvectionRadiationTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTIVE_RADIATIVE_HEAT_TRANSFER";

    [JsonPropertyName("convection")]
    public WallConvectionModel? Convection { get; set; }

    [JsonPropertyName("radiation")]
    public WallRadiationModel? Radiation { get; set; }

}
