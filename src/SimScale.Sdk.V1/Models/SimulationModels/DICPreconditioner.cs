using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Diagonal incomplete Cholesky algorithm for symmetric matrices without fill-in.</summary>
public class DICPreconditioner : OneOf_PCGSolverPreconditioner, OneOf_PBICGStabSolverPreconditioner
{
    /// <summary>Diagonal incomplete Cholesky algorithm for symmetric matrices without fill-in. Schema name: DICPreconditioner</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DIC";

}
