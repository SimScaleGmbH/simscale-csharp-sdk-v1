using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticReynoldsScaling : OneOf_PacefishAutomeshReynoldsScalingType, OneOf_WindComfortMeshReynoldsScalingType
{
    /// <summary>Schema name: AutomaticReynoldsScaling</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_REYNOLDS_SCALING";

}
