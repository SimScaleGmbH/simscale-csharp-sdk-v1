using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DisplacementsConvergenceMethod : OneOf_MarcNonlinearSolverSettingsConvergenceMethod
{
    /// <summary>Schema name: DisplacementsConvergenceMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISPLACEMENTS";

    [JsonPropertyName("convergenceCriteria")]
    public OneOf_DisplacementsConvergenceMethodConvergenceCriteria? ConvergenceCriteria { get; set; }

}
