using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteConvergenceResiduals : OneOf_ResidualsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AbsoluteConvergenceResiduals</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    [JsonPropertyName("maxResidualForce")]
    public Dimensional_Force? MaxResidualForce { get; set; }

    [JsonPropertyName("maxResidualMoment")]
    public Dimensional_Torque? MaxResidualMoment { get; set; }

}
