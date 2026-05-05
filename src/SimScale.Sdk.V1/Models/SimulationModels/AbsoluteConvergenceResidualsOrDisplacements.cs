using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteConvergenceResidualsOrDisplacements : OneOf_ResidualsOrDisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AbsoluteConvergenceResidualsOrDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    [JsonPropertyName("maxResidualForce")]
    public Dimensional_Force? MaxResidualForce { get; set; }

    [JsonPropertyName("maxResidualMoment")]
    public Dimensional_Torque? MaxResidualMoment { get; set; }

    [JsonPropertyName("maxDisplacementIncrement")]
    public Dimensional_Length? MaxDisplacementIncrement { get; set; }

    [JsonPropertyName("maxRotationIncrement")]
    public Dimensional_Angle? MaxRotationIncrement { get; set; }

}
