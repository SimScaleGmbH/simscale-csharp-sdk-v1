using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Layer inflation allows the creation of prismatic boundary layers for certain mesh regions.Prismatic layers are mostly used in CFD simulations on no-slip walls in order to efficiently capture the boundary layer velocity profile, but they may be also used in certain structural simulations like stamping or deep-drawing processes. The figure shows a sample mesh with boundary layers added.</summary>
public class LayerRefinement
{
    /// <summary>Layer inflation allows the creation of prismatic boundary layers for certain mesh regions.Prismatic layers are mostly...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LAYER_INFLATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>This parameter controls the overall thickness of all the generated boundary layers together. This value must be small...</summary>
    [JsonPropertyName("totalThickness")]
    public double? TotalThickness { get; set; }

    /// <summary>The number of layers defines how many prismatic boundary layers should be created.</summary>
    [JsonPropertyName("layers")]
    public int? Layers { get; set; }

    /// <summary>The stretch factor determines how the boundary layers grow in thickness from the wall to the internal mesh. The large...</summary>
    [JsonPropertyName("stretchFactor")]
    public double? StretchFactor { get; set; }

    /// <summary>This parameter determines if quadrangular surface elements shall be allowed. When disabled, only triangles will be us...</summary>
    [JsonPropertyName("allowQuadrangles")]
    public bool? AllowQuadrangles { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
