using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Crout's version of the incomplete lower-upper (ILU) algorithm with arbitrary level of fill-in.</summary>
public class ILUCpPreconditioner : OneOf_PCGSolverPreconditioner, OneOf_PBICGStabSolverPreconditioner, OneOf_PBICGSolverPreconditioner
{
    /// <summary>Crout's version of the incomplete lower-upper (ILU) algorithm with arbitrary level of fill-in. Schema name: ILUCpPrec...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ILUCP";

    /// <summary>Number of face-neighbour layers to fill in. Increasing the level of fill-in improves the performance of preconditione...</summary>
    [JsonPropertyName("fillInLevel")]
    public int? FillInLevel { get; set; }

}
