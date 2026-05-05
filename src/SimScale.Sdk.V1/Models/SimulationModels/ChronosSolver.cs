using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ChronosSolver : OneOf_SolidNumericsSolver
{
    /// <summary>Schema name: ChronosSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CHRONOS";

    /// <summary>Select the convergence tolerance. Can be smaller than with PETSc, and has a big impact on the newton convergence. It...</summary>
    [JsonPropertyName("convergenceThreshold")]
    public double? ConvergenceThreshold { get; set; }

    /// <summary>Maximum number of iterations for Chronos. Should be 1000 for AMG (max 3000), and 5000 with FSAI (max 10000).</summary>
    [JsonPropertyName("maxIterations")]
    public int? MaxIterations { get; set; }

    /// <summary>Choose what happens if the linear solution with Chronos fails. Either stop the simulation, or rerun it with a direct...</summary>
    [JsonPropertyName("nonConvergenceAction")]
    public string? NonConvergenceAction { get; set; }

    [JsonPropertyName("advancedSettings")]
    public AdvancedChronosSettings? AdvancedSettings { get; set; }

}
