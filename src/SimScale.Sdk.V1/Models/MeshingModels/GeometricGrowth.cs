using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class GeometricGrowth : OneOf_SimmetrixBoundaryLayerRefinementLayerType, OneOf_AutomaticLayerOnLayerType
{
    /// <summary>Schema name: GeometricGrowth</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GEOMETRIC_GROWTH";

    /// <summary>The Number of layers defines how many prismatic boundary layers should be created. 3 is default.</summary>
    [JsonPropertyName("numberOfLayers")]
    public int? NumberOfLayers { get; set; }

    [JsonPropertyName("totalAbsoluteThickness")]
    public Dimensional_Length? TotalAbsoluteThickness { get; set; }

    [JsonPropertyName("firstLayerSize")]
    public Dimensional_Length? FirstLayerSize { get; set; }

}
