using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedMUMPSSettings
{
    /// <summary>Choose if you want to enforce a symmetric matrix.</summary>
    [JsonPropertyName("forceSymmetric")]
    public bool? ForceSymmetric { get; set; }

    /// <summary>Enable the check for singularities in the model. This is helpful for debugging, to spot problems with the setup.</summary>
    [JsonPropertyName("enableSingularityDetection")]
    public bool? EnableSingularityDetection { get; set; }

    /// <summary>Define the precision value for the detection of a singular matrix. Positive values enable the check, with 9 being a g...</summary>
    [JsonPropertyName("precisionSingularityDetection")]
    public int? PrecisionSingularityDetection { get; set; }

    /// <summary>Choose if the calculation should be stopped if the problem turns out to be singular.</summary>
    [JsonPropertyName("stopIfSingular")]
    public bool? StopIfSingular { get; set; }

    /// <summary>Choose the type of your system matrix by directly selecting the appropriate type or using the automatic detection. Wi...</summary>
    [JsonPropertyName("matrixType")]
    public string? MatrixType { get; set; }

    /// <summary>Define how much additional memory should be reserved for the pivoting operations. If MUMPS estimates that the necessa...</summary>
    [JsonPropertyName("memoryPercentageForPivoting")]
    public double? MemoryPercentageForPivoting { get; set; }

    /// <summary>Set the maximum allowable numerical error in solving the linear equation system. Use -1 if you do not wish to carry o...</summary>
    [JsonPropertyName("linearSystemRelativeResidual")]
    public double? LinearSystemRelativeResidual { get; set; }

    /// <summary>This parameter allows a filtration of the matrix entries that are saved and possibly passed to the nonlinear algorith...</summary>
    [JsonPropertyName("matrixFilteringThreshold")]
    public double? MatrixFilteringThreshold { get; set; }

    /// <summary>If this option is activated the matrix factorisation is done with single precision and thus a reduction in memory con...</summary>
    [JsonPropertyName("singlePrecision")]
    public bool? SinglePrecision { get; set; }

    /// <summary>If this option is activated MUMPS performs a pre-processing on order to identify the best parameter setting for some...</summary>
    [JsonPropertyName("preprocessing")]
    public bool? Preprocessing { get; set; }

    /// <summary>Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on...</summary>
    [JsonPropertyName("renumberingMethod")]
    public string? RenumberingMethod { get; set; }

    /// <summary>With this option the user can control the iterative refinement of the linear system solution. This option only has an...</summary>
    [JsonPropertyName("postprocessing")]
    public string? Postprocessing { get; set; }

    [JsonPropertyName("mumpsAcceleration")]
    public OneOf_AdvancedMUMPSSettingsMumpsAcceleration? MumpsAcceleration { get; set; }

    /// <summary>Choose this parameter as true to ensure that the system matrix saving is distributed among the processors of the comp...</summary>
    [JsonPropertyName("distributedMatrixStorage")]
    public bool? DistributedMatrixStorage { get; set; }

}
