using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class FirstLayerGrowth : OneOf_SimmetrixBoundaryLayerRefinementLayerType, OneOf_AutomaticLayerOnLayerType
{
    /// <summary>Schema name: FirstLayerGrowth</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIRST_LAYER_GROWTH";

    /// <summary>The Number of layers defines how many prismatic boundary layers should be created. 3 is default.</summary>
    [JsonPropertyName("numberOfLayers")]
    public int? NumberOfLayers { get; set; }

    /// <summary>The Growth rate defines the thickness ratio between adjacent boundary layer cells. It needs to be always greater than...</summary>
    [JsonPropertyName("growthRate")]
    public double? GrowthRate { get; set; }

    [JsonPropertyName("firstLayerSize")]
    public Dimensional_Length? FirstLayerSize { get; set; }

}
