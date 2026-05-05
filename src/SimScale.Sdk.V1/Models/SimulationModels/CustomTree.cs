using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomTree : OneOf_PorousTreeTreeType
{
    /// <summary>Schema name: CustomTree</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_TREE";

    /// <summary>Leaf Area Index (LAI) is a dimensionless quantity that is defined as the leaf area per unit ground surface area in br...</summary>
    [JsonPropertyName("leafAreaIndex")]
    public double? LeafAreaIndex { get; set; }

    [JsonPropertyName("averageTreeHeight")]
    public Dimensional_Length? AverageTreeHeight { get; set; }

    /// <summary>Drag coefficient of the tree canopy.</summary>
    [JsonPropertyName("dragCoefficient")]
    public double? DragCoefficient { get; set; }

}
