using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class MeshQualityControls
{
    [JsonPropertyName("maxNonOrthogonality")]
    public Dimensional_Angle? MaxNonOrthogonality { get; set; }

    [JsonPropertyName("maxBoundarySkewness")]
    public Dimensional_Angle? MaxBoundarySkewness { get; set; }

    [JsonPropertyName("maxInternalSkewness")]
    public Dimensional_Angle? MaxInternalSkewness { get; set; }

    [JsonPropertyName("maxConcaveness")]
    public Dimensional_Angle? MaxConcaveness { get; set; }

    [JsonPropertyName("minVolume")]
    public Dimensional_Volume? MinVolume { get; set; }

    /// <summary>Define a minimum tetrahedron quality for cells (see documentation). Choose a low negative number to disable this chec...</summary>
    [JsonPropertyName("minTetQuality")]
    public double? MinTetQuality { get; set; }

    [JsonPropertyName("minFaceArea")]
    public Dimensional_Area? MinFaceArea { get; set; }

    /// <summary>Define the minimum cosine of face twist allowed (see documentation). Set to a value smaller than -1 to disable. The v...</summary>
    [JsonPropertyName("minFaceTwist")]
    public double? MinFaceTwist { get; set; }

    /// <summary>Define the minimum normalised cell determinant. Choose a value between 0 and 1. Hex corresponds to 1.</summary>
    [JsonPropertyName("minDeterminant")]
    public double? MinDeterminant { get; set; }

    /// <summary>The face weight specifies the distribution of a face's contribution to its two neighbouring cells. A very small face...</summary>
    [JsonPropertyName("minFaceWeight")]
    public double? MinFaceWeight { get; set; }

    /// <summary>This parameter specifies the minimum allowed volume ratio between two adjacent cells. Choose a value between 0 and 1....</summary>
    [JsonPropertyName("minVolumeRatio")]
    public double? MinVolumeRatio { get; set; }

    /// <summary>Same as Min Face Twist, but for adjacent triangular faces (see documentation). Choose a value below -1 to disable thi...</summary>
    [JsonPropertyName("minTriangleTwist")]
    public double? MinTriangleTwist { get; set; }

    /// <summary>Define the number of error distribution iterations.</summary>
    [JsonPropertyName("errorDistributionIterations")]
    public int? ErrorDistributionIterations { get; set; }

    /// <summary>This parameter specifies how much the displacement is scaled at error locations.</summary>
    [JsonPropertyName("errorReduction")]
    public double? ErrorReduction { get; set; }

    [JsonPropertyName("relaxedMaxNonOrthogonality")]
    public Dimensional_Angle? RelaxedMaxNonOrthogonality { get; set; }

    /// <summary>This parameters specifies the accuracy of face merging as a fraction of the initial bounding box.</summary>
    [JsonPropertyName("mergeTolerance")]
    public double? MergeTolerance { get; set; }

}
