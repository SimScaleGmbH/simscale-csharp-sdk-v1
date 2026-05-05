using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ResolvedTurbulentKineticEnergy
{
    /// <summary>Schema name: ResolvedTurbulentKineticEnergy</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESOLVED_TURBULENT_KINETIC_ENERGY";

}
