using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConvectionTBC : OneOf_WallBCTemperature
{
    /// <summary>Schema name: ConvectionTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTIVE_HEAT_TRANSFER";

    [JsonPropertyName("convection")]
    public WallConvectionModel? Convection { get; set; }

}
