using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>This option enables layer refinement on the faces of the bounding box. This refinement is useful if the bounding box itself provides walls of the flow domain. It is often used for external aerodynamic cases where the floor is considered as a wall and hence the mesh should be refined with layers in the vicinity.</summary>
public class BoundingBoxLayerAddition
{
    /// <summary>This option enables layer refinement on the faces of the bounding box. This refinement is useful if the bounding box...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOUNDING_BOX_LAYER_ADDITION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (den...</summary>
    [JsonPropertyName("face")]
    public string? Face { get; set; }

    /// <summary>The number of layers defines how many boundary layers should be created.</summary>
    [JsonPropertyName("layers")]
    public int? Layers { get; set; }

    /// <summary>The Expansion ratio determines how the boundary layers grow in thickness from the wall to the internal mesh. The larg...</summary>
    [JsonPropertyName("expansionRatio")]
    public double? ExpansionRatio { get; set; }

    [JsonPropertyName("minThickness")]
    public Dimensional_Length? MinThickness { get; set; }

    [JsonPropertyName("finalThickness")]
    public Dimensional_Length? FinalThickness { get; set; }

}
