using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_HEIGHT
{
    [JsonPropertyName("HEIGHT")]
    public Unit_Length? Height { get; set; }

}
