using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedChronosSettings
{
    /// <summary>Force the usage of FSAI preconditioning. This can make sense for small and simple problems, because setting up the pr...</summary>
    [JsonPropertyName("forceFsai")]
    public bool? ForceFsai { get; set; }

    /// <summary>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability...</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability...</summary>
    [JsonPropertyName("smoother")]
    public string? Smoother { get; set; }

    /// <summary>The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stabi...</summary>
    [JsonPropertyName("prolongation")]
    public string? Prolongation { get; set; }

    /// <summary>This should be enabled only for very complex/ill-conditioned problems, e.g. highly constrained with many BCs, incompr...</summary>
    [JsonPropertyName("improveTestSpace")]
    public bool? ImproveTestSpace { get; set; }

    /// <summary>Defaults to 20, can be increased to 50 for complicated cases.</summary>
    [JsonPropertyName("testSpaceIterations")]
    public int? TestSpaceIterations { get; set; }

    /// <summary>Specify the recycling of the preconditioner. This can have a significant impact on the performance. The input is as f...</summary>
    [JsonPropertyName("preconditionerRecycling")]
    public double? PreconditionerRecycling { get; set; }

    /// <summary>Choose after how many iterations the GMRES solver should be restarted.By default, Chronos uses a PCG iterative soluti...</summary>
    [JsonPropertyName("restartGmres")]
    public int? RestartGmres { get; set; }

    /// <summary>Choose this parameter as true to ensure that the system matrix saving is distributed among the processors of the comp...</summary>
    [JsonPropertyName("distributedMatrixStorage")]
    public bool? DistributedMatrixStorage { get; set; }

    /// <summary>Sets the number of threads for Chronos to be used for shared memory parallelization.The shared memory parallelization...</summary>
    [JsonPropertyName("numOfThreads")]
    public int? NumOfThreads { get; set; }

    /// <summary>This is a DEVELOPER option to specify the amount of output from Chronos. Its only purpose is debugging. Don't use it...</summary>
    [JsonPropertyName("verbosity")]
    public int? Verbosity { get; set; }

    /// <summary>This is a DEVELOPER option to output the coordinates and the matrix to a file. Its only purpose is debugging. Don't u...</summary>
    [JsonPropertyName("writeCoordsAndMatrix")]
    public int? WriteCoordsAndMatrix { get; set; }

}
