using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class FractionalHeight1 : OneOf_SimmetrixBoundaryLayerRefinementLayerType, OneOf_AutomaticLayerOnLayerType
{
    /// <summary>Schema name: FractionalHeight1</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRACTIONAL_HEIGHT_1";

    /// <summary>The Number of layers defines how many prismatic boundary layers should be created. 3 is default.</summary>
    [JsonPropertyName("numberOfLayers")]
    public int? NumberOfLayers { get; set; }

    /// <summary>It defines the thickness of all prismatic boundary layers combined in relation to the local element size.Example 3-la...</summary>
    [JsonPropertyName("totalRelativeThickness")]
    public double? TotalRelativeThickness { get; set; }

    [JsonPropertyName("firstLayerSize")]
    public Dimensional_Length? FirstLayerSize { get; set; }

}
