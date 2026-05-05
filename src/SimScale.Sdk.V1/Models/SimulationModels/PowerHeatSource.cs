using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PowerHeatSource : OneOf_TurbulentHeatFluxTBCHeatSource
{
    /// <summary>Schema name: PowerHeatSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POWER";

    [JsonPropertyName("power")]
    public Dimensional_Power? Power { get; set; }

}
