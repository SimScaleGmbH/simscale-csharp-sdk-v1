using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class QZ : OneOf_ModalSolverEigenSolver, OneOf_SolidNumericsEigenSolver
{
    /// <summary>Schema name: QZ</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "QZ";

    [JsonPropertyName("typeQZ")]
    public string? TypeQZ { get; set; }

}
