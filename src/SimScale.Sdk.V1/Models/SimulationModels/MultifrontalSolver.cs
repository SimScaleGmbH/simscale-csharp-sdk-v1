using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MultifrontalSolver : OneOf_ModalSolverSolver, OneOf_SolidNumericsSolver
{
    /// <summary>Schema name: MultifrontalSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTIFRONT";

    /// <summary>Choose a renumbering method for the solution process.For large models around and above 50000 degrees of freedom you s...</summary>
    [JsonPropertyName("renumberingMethod")]
    public string? RenumberingMethod { get; set; }

    /// <summary>Choose if you want to enforce a symmetric matrix.</summary>
    [JsonPropertyName("forceSymmetric")]
    public bool? ForceSymmetric { get; set; }

    /// <summary>Define the precision value for the detection of a singular matrix. Positive values enable the check, with 9 being a g...</summary>
    [JsonPropertyName("precisionSingularityDetection")]
    public int? PrecisionSingularityDetection { get; set; }

    /// <summary>Choose if the calculation should be stopped if the problem turns out to be singular.</summary>
    [JsonPropertyName("stopIfSingular")]
    public bool? StopIfSingular { get; set; }

    /// <summary>This option makes it possible to eliminate the Lagrange Multipliers which are introduced by generalized boundary cond...</summary>
    [JsonPropertyName("eliminateLagrangeMultipliers")]
    public bool? EliminateLagrangeMultipliers { get; set; }

}
