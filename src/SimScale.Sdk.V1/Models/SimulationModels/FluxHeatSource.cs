using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluxHeatSource : OneOf_TurbulentHeatFluxTBCHeatSource
{
    /// <summary>Schema name: FluxHeatSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLUX";

    [JsonPropertyName("heatFlux")]
    public Dimensional_HeatFlux? HeatFlux { get; set; }

}
