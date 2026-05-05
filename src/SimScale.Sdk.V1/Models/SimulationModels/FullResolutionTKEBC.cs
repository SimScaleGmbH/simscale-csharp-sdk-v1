using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FullResolutionTKEBC : OneOf_CustomFluidBCTurbulentKineticEnergy
{
    /// <summary>Schema name: FullResolutionTKEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FULL_RESOLUTION";

}
