using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class LayerAddingControls
{
    /// <summary>If turned on, the length parameters for layer refinements (e.g. 'Thickness of the final layer', 'Minimum overall laye...</summary>
    [JsonPropertyName("relativeSize")]
    public bool? RelativeSize { get; set; }

    /// <summary>If the algorithm faces difficulty generating layers, this is the maximum number of layers that are NOT generated in t...</summary>
    [JsonPropertyName("maxCancelledLayersNearSharpFeatures")]
    public int? MaxCancelledLayersNearSharpFeatures { get; set; }

    [JsonPropertyName("featureAngle")]
    public Dimensional_Angle? FeatureAngle { get; set; }

    [JsonPropertyName("slipFeatureAngle")]
    public Dimensional_Angle? SlipFeatureAngle { get; set; }

    /// <summary>Specify the maximum number of relaxation iterations for the snapping process for layers.</summary>
    [JsonPropertyName("relaxIterations")]
    public int? RelaxIterations { get; set; }

    /// <summary>Specify the maximum number of smoothing iterations for the surface normals.</summary>
    [JsonPropertyName("surfaceNormalsMaxSmoothingIterations")]
    public int? SurfaceNormalsMaxSmoothingIterations { get; set; }

    /// <summary>Specify the number of smoothing iterations for the interior mesh movement. This movement occurs in order to make spac...</summary>
    [JsonPropertyName("internalMeshMaxSmoothingIterations")]
    public int? InternalMeshMaxSmoothingIterations { get; set; }

    /// <summary>This specifies the number of iterations for smoothing of the overall layer thickness over different surface patches.</summary>
    [JsonPropertyName("layerThicknessMaxSmoothingIterations")]
    public int? LayerThicknessMaxSmoothingIterations { get; set; }

    /// <summary>Specify the maximum allowable face aspect ratio beyond which layers will not be added.</summary>
    [JsonPropertyName("maxFaceThicknessRatio")]
    public double? MaxFaceThicknessRatio { get; set; }

    /// <summary>The medial length is a measure of the aspect ratio for a non-quadrilateral face. This parameter prevents layer additi...</summary>
    [JsonPropertyName("maxThicknessToMedialRatio")]
    public double? MaxThicknessToMedialRatio { get; set; }

    [JsonPropertyName("minMedianAxisAngle")]
    public Dimensional_Angle? MinMedianAxisAngle { get; set; }

    /// <summary>This parameter specifies the number of buffer cells to be extruded at cell-faces where layers terminate. Set to</summary>
    [JsonPropertyName("bufferCellsNoExtrude")]
    public int? BufferCellsNoExtrude { get; set; }

    /// <summary>Specify the overall layer addition iteration number. The algorithm will abort definitely as soon as this number is re...</summary>
    [JsonPropertyName("layerAdditionMaxIterations")]
    public int? LayerAdditionMaxIterations { get; set; }

    /// <summary>This parameter specifies the maximum number of layer iterations that are done with the mesh quality controls. On exce...</summary>
    [JsonPropertyName("maxIterationsWithStrictQualityControls")]
    public int? MaxIterationsWithStrictQualityControls { get; set; }

}
