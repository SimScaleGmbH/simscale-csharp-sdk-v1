using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TurbulentHeatFluxTBC : OneOf_CustomFluidBCTemperature, OneOf_WallBCTemperature
{
    /// <summary>Schema name: TurbulentHeatFluxTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENT_HEAT_FLUX_TEMPERATURE";

    [JsonPropertyName("heatSource")]
    public OneOf_TurbulentHeatFluxTBCHeatSource? HeatSource { get; set; }

    [JsonPropertyName("value")]
    public Dimensional_Temperature? Value { get; set; }

}
