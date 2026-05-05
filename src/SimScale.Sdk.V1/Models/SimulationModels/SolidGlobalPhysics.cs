using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidGlobalPhysics
{
    /// <summary>Apply a constant level of damping to all parts that do not have a specified material damping behavior.</summary>
    [JsonPropertyName("enableGlobalDamping")]
    public bool? EnableGlobalDamping { get; set; }

    /// <summary>Specify the level of damping to be applied globally as a percentage of critical damping.</summary>
    [JsonPropertyName("dampingLevel")]
    public double? DampingLevel { get; set; }

}
