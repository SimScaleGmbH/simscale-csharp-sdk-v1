using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Inflated boundary layers are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.</summary>
public class LayerAdditionHexDominantSnappy : OneOf_HexDominantSnappyRefinements
{
    /// <summary>Inflated boundary layers are used to resolve the boundary layer near walls (no-slip) which are in contact with the fl...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LAYER_ADDITION_HEX_DOMINANT_SNAPPY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of layers defines how many boundary layers should be created.</summary>
    [JsonPropertyName("layers")]
    public int? Layers { get; set; }

    /// <summary>The Expansion ratio determines how the boundary layers grow in thickness from the wall to the internal mesh. The larg...</summary>
    [JsonPropertyName("expansionRatio")]
    public double? ExpansionRatio { get; set; }

    /// <summary>Specifies the overall minimum thickness of all layers combined. In case the overall thickness falls below this minimu...</summary>
    [JsonPropertyName("minThickness")]
    public double? MinThickness { get; set; }

    /// <summary>Specifies the height (thickness) of the first layer that is closest to the surface. The first layer thickness is spec...</summary>
    [JsonPropertyName("firstLayerThickness")]
    public double? FirstLayerThickness { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
