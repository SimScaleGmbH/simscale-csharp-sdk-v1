using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IRAMSorensen : OneOf_ModalSolverEigenSolver, OneOf_SolidNumericsEigenSolver
{
    /// <summary>Schema name: IRAMSorensen</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SORENSEN";

    [JsonPropertyName("precSoren")]
    public double? PrecSoren { get; set; }

    [JsonPropertyName("nmaxIterSoren")]
    public int? NmaxIterSoren { get; set; }

    [JsonPropertyName("subspaceSettings")]
    public OneOf_IRAMSorensenSubspaceSettings? SubspaceSettings { get; set; }

}
