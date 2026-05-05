using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ExternalWallHeatFluxTBC : OneOf_CustomFluidBCTemperature, OneOf_WallBCTemperature
{
    /// <summary>Schema name: ExternalWallHeatFluxTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EXTERNAL_WALL_HEAT_FLUX_TEMPERATURE";

    [JsonPropertyName("heatFlux")]
    public OneOf_ExternalWallHeatFluxTBCHeatFlux? HeatFlux { get; set; }

    [JsonPropertyName("value")]
    public Dimensional_Temperature? Value { get; set; }

}
