using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TrueSemiImplicit : OneOf_MULESSolverSemiImplicit
{
    /// <summary>Schema name: TrueSemiImplicit</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRUE_SEMI_IMPLICIT";

    [JsonPropertyName("limiterIterations")]
    public int? LimiterIterations { get; set; }

    [JsonPropertyName("compressionCorrection")]
    public bool? CompressionCorrection { get; set; }

    [JsonPropertyName("solver")]
    public OneOf_TrueSemiImplicitSolver? Solver { get; set; }

}
