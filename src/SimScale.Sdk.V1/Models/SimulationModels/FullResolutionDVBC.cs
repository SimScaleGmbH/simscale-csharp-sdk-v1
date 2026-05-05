using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FullResolutionDVBC : OneOf_CustomFluidBCTurbulentDynamicViscosity
{
    /// <summary>Schema name: FullResolutionDVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FULL_RESOLUTION";

}
