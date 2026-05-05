using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ResidualsConvergenceMethod : OneOf_MarcNonlinearSolverSettingsConvergenceMethod
{
    /// <summary>Schema name: ResidualsConvergenceMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RESIDUALS";

    [JsonPropertyName("convergenceCriteria")]
    public OneOf_ResidualsConvergenceMethodConvergenceCriteria? ConvergenceCriteria { get; set; }

}
