using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_R_PHI_Z_TIME
{
    [JsonPropertyName("T")]
    public Unit_Time? T { get; set; }

    [JsonPropertyName("R")]
    public Unit_Length? R { get; set; }

    [JsonPropertyName("PHI_ANGLE")]
    public Unit_Angle? PhiAngle { get; set; }

    [JsonPropertyName("Z")]
    public Unit_Length? Z { get; set; }

}
