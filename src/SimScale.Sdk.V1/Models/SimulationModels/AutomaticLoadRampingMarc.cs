using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticLoadRampingMarc
{
    /// <summary>Define when the reference value for the kinematic condition is computed during the simulated time: at the beginning o...</summary>
    [JsonPropertyName("referencePosition")]
    public string? ReferencePosition { get; set; }

    /// <summary>Define the behavior of the boundary condition when it is deactivated. This behavior is applied during the first load...</summary>
    [JsonPropertyName("releaseBehavior")]
    public string? ReleaseBehavior { get; set; }

}
