using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoWallThermal : OneOf_DerivedHeatFluxWallThermal
{
    /// <summary>Schema name: NoWallThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_RESISTANCE";

}
