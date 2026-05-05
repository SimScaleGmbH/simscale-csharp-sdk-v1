using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceWaterVaporFluxHumidityBC : OneOf_WallBCRelativeHumidity
{
    /// <summary>Schema name: SurfaceWaterVaporFluxHumidityBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_WATER_VAPOR_FLUX";

    [JsonPropertyName("waterVaporFlux")]
    public Dimensional_EddyViscosityGradient? WaterVaporFlux { get; set; }

}
