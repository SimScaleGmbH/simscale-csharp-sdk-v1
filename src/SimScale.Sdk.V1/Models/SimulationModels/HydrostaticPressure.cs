using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HydrostaticPressure
{
    [JsonPropertyName("enableHydrostaticPressure")]
    public bool? EnableHydrostaticPressure { get; set; }

    [JsonPropertyName("referenceHeight")]
    public Dimensional_Length? ReferenceHeight { get; set; }

}
