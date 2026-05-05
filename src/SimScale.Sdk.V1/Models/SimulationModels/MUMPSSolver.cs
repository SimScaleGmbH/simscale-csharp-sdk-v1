using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MUMPSSolver : OneOf_ModalSolverSolver, OneOf_SolidNumericsSolver
{
    /// <summary>Schema name: MUMPSSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MUMPS";

    [JsonPropertyName("advancedMumpsSettings")]
    public AdvancedMUMPSSettings? AdvancedMumpsSettings { get; set; }

}
