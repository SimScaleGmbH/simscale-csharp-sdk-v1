using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualReynoldsScaling : OneOf_PacefishAutomeshReynoldsScalingType, OneOf_WindComfortMeshReynoldsScalingType
{
    /// <summary>Schema name: ManualReynoldsScaling</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_REYNOLDS_SCALING";

    [JsonPropertyName("reynoldsScalingFactor")]
    public double? ReynoldsScalingFactor { get; set; }

}
