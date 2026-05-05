using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Inflated boundary layers are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.</summary>
public class LayerAddition
{
    /// <summary>Inflated boundary layers are used to resolve the boundary layer near walls (no-slip) which are in contact with the fl...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LAYER_ADDITION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of layers defines how many boundary layers should be created.</summary>
    [JsonPropertyName("layers")]
    public int? Layers { get; set; }

    /// <summary>The Expansion ratio determines how the boundary layers grow in thickness from the wall to the internal mesh. The larg...</summary>
    [JsonPropertyName("expansionRatio")]
    public double? ExpansionRatio { get; set; }

    /// <summary>This is the overall minimum thickness of all added layers. If for any case the overall layer thickness is smaller tha...</summary>
    [JsonPropertyName("minThickness")]
    public double? MinThickness { get; set; }

    /// <summary>Specify the desired final layer thickness farthest away from the wall on which the boundary layer is grown. If the 'L...</summary>
    [JsonPropertyName("finalLayerThickness")]
    public double? FinalLayerThickness { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
