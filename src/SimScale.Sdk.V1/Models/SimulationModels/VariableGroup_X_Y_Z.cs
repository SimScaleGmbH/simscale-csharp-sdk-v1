using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_X_Y_Z
{
    [JsonPropertyName("X")]
    public Unit_Length? X { get; set; }

    [JsonPropertyName("Y")]
    public Unit_Length? Y { get; set; }

    [JsonPropertyName("Z")]
    public Unit_Length? Z { get; set; }

}
