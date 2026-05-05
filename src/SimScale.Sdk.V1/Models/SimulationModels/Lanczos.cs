using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Lanczos : OneOf_ModalSolverEigenSolver, OneOf_SolidNumericsEigenSolver
{
    /// <summary>Schema name: Lanczos</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRI_DIAG";

    [JsonPropertyName("precOrtho")]
    public double? PrecOrtho { get; set; }

    [JsonPropertyName("nmaxIterOrtho")]
    public int? NmaxIterOrtho { get; set; }

    [JsonPropertyName("precLanczos")]
    public double? PrecLanczos { get; set; }

    [JsonPropertyName("maxIterQR")]
    public int? MaxIterQR { get; set; }

    [JsonPropertyName("modeRigid")]
    public bool? ModeRigid { get; set; }

    [JsonPropertyName("subspaceSettings")]
    public OneOf_LanczosSubspaceSettings? SubspaceSettings { get; set; }

}
