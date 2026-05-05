using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedPETSCSettings
{
    /// <summary>Choose if you want to enforce a symmetric matrix.</summary>
    [JsonPropertyName("forceSymmetric")]
    public bool? ForceSymmetric { get; set; }

    /// <summary>Choose the iterative solver method: FGMRES: Flexible Minimal Generalised RESidual, best compromise between robustness...</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    [JsonPropertyName("preconditioner")]
    public OneOf_AdvancedPETSCSettingsPreconditioner? Preconditioner { get; set; }

    /// <summary>Choose this parameter as true to ensure that the system matrix saving is distributed among the processors of the comp...</summary>
    [JsonPropertyName("distributedMatrixStorage")]
    public bool? DistributedMatrixStorage { get; set; }

}
