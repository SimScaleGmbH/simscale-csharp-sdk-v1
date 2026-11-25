using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_THETA_TIME
{
    [JsonPropertyName("T")]
    public Unit_Time? T { get; set; }

    [JsonPropertyName("THETA_ANGLE")]
    public Unit_Angle? ThetaAngle { get; set; }

}
