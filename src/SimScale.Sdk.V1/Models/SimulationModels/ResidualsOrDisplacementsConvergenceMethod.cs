using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ResidualsOrDisplacementsConvergenceMethod : OneOf_MarcNonlinearSolverSettingsConvergenceMethod
{
    /// <summary>Schema name: ResidualsOrDisplacementsConvergenceMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESIDUALS_OR_DISPLACEMENTS";

    [JsonPropertyName("convergenceCriteria")]
    public OneOf_ResidualsOrDisplacementsConvergenceMethodConvergenceCriteria? ConvergenceCriteria { get; set; }

}
