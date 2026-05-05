using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalTurbulentKineticEnergy
{
    /// <summary>Schema name: TotalTurbulentKineticEnergy</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_TURBULENT_KINETIC_ENERGY";

}
