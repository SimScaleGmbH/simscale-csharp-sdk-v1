using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpringDamper
{
    [JsonPropertyName("stiffness")]
    public Dimensional_Stiffness? Stiffness { get; set; }

    [JsonPropertyName("springOffset")]
    public Dimensional_Length? SpringOffset { get; set; }

    [JsonPropertyName("dampingFactor")]
    public Dimensional_Damping? DampingFactor { get; set; }

}
