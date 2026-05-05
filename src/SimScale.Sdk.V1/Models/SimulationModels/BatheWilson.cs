using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BatheWilson : OneOf_ModalSolverEigenSolver, OneOf_SolidNumericsEigenSolver
{
    /// <summary>Schema name: BatheWilson</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "JACOBI";

    [JsonPropertyName("precBathe")]
    public double? PrecBathe { get; set; }

    [JsonPropertyName("nmaxIterBathe")]
    public int? NmaxIterBathe { get; set; }

    [JsonPropertyName("precJacobi")]
    public double? PrecJacobi { get; set; }

    [JsonPropertyName("maxIterJacobi")]
    public int? MaxIterJacobi { get; set; }

    [JsonPropertyName("subspaceSettings")]
    public OneOf_BatheWilsonSubspaceSettings? SubspaceSettings { get; set; }

}
