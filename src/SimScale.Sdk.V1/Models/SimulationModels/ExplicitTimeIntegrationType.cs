using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the time integration scheme typeImportant remarks:Choose implicit if the problem is static or dynamic but not so complex. Implicit analysis takes more solution time but can solve the problem easily with larger timesteps. Therefore, it is always recommended to use implicit time integration scheme. Choose explicit if the problem is only dynamic and highly complex. Explicit analysis takes less solution time but also needs more refined (small) timesteps to solve the problem. Therefore, in most of the cases it's not recommended due to convergence problems.</summary>
public class ExplicitTimeIntegrationType : OneOf_SolidNumericsMechanicalTimeIntegrationType
{
    /// <summary>Choose the time integration scheme typeImportant remarks:Choose implicit if the problem is static or dynamic but not...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EXPLICIT";

    [JsonPropertyName("scheme")]
    public OneOf_ExplicitTimeIntegrationTypeScheme? Scheme { get; set; }

    /// <summary>Choose the primary variable for the time integration scheme.</summary>
    [JsonPropertyName("schemeFormulation")]
    public string? SchemeFormulation { get; set; }

    /// <summary>If activated the simulation run is stopped when at some point the Courant-Friedrichs-Lewy (CFL) condition is violated.</summary>
    [JsonPropertyName("stopOnCFLCriterion")]
    public bool? StopOnCFLCriterion { get; set; }

    /// <summary>This parameter cK allows the shifting of the mass matrix with the stiffness matrix multiplied by cK: M'=M + cK*K. Thi...</summary>
    [JsonPropertyName("massMatrixShift")]
    public double? MassMatrixShift { get; set; }

}
