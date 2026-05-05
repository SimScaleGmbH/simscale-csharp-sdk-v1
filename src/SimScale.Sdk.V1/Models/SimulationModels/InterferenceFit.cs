using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InterferenceFit
{
    /// <summary>Enable Interference fit to resolve the initial penetration as a physical load (press-fit) rather than a geometric ina...</summary>
    [JsonPropertyName("enableInterferenceFit")]
    public bool? EnableInterferenceFit { get; set; }

    [JsonPropertyName("closure")]
    public DimensionalFunction_Length? Closure { get; set; }

}
