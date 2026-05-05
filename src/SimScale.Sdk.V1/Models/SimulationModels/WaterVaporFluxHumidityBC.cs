using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WaterVaporFluxHumidityBC : OneOf_WallBCRelativeHumidity
{
    /// <summary>Schema name: WaterVaporFluxHumidityBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WATER_VAPOR_FLUX";

    [JsonPropertyName("waterVaporFlux")]
    public Dimensional_MassFlowRate? WaterVaporFlux { get; set; }

}
