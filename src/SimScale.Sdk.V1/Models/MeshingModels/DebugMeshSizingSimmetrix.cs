using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class DebugMeshSizingSimmetrix
{
    /// <summary>Schema name: DebugMeshSizingSimmetrix</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DEBUG";

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

    [JsonPropertyName("chordalError")]
    public double? ChordalError { get; set; }

    [JsonPropertyName("minCurvRef")]
    public double? MinCurvRef { get; set; }

    [JsonPropertyName("gradationRate")]
    public double? GradationRate { get; set; }

    [JsonPropertyName("proxRefFactor")]
    public double? ProxRefFactor { get; set; }

    [JsonPropertyName("minProxSize")]
    public Dimensional_Length? MinProxSize { get; set; }

    [JsonPropertyName("smallFeatureTol")]
    public double? SmallFeatureTol { get; set; }

    [JsonPropertyName("layerAdjustmentBehaviour")]
    public string? LayerAdjustmentBehaviour { get; set; }

    [JsonPropertyName("layerHeightGradationRate")]
    public double? LayerHeightGradationRate { get; set; }

    [JsonPropertyName("surfSkewness")]
    public double? SurfSkewness { get; set; }

    [JsonPropertyName("volLenRatio")]
    public double? VolLenRatio { get; set; }

}
