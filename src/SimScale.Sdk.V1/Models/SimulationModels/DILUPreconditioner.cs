using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Diagonal incomplete lower-upper (ILU) algorithm for non-symmetric matrices without fill-in.</summary>
public class DILUPreconditioner : OneOf_PBICGStabSolverPreconditioner, OneOf_PBICGSolverPreconditioner
{
    /// <summary>Diagonal incomplete lower-upper (ILU) algorithm for non-symmetric matrices without fill-in. Schema name: DILUPrecondi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DILU";

}
