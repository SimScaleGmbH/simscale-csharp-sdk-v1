using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FullResolutionEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: FullResolutionEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FULL_RESOLUTION";

}
