using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DirectionalMaterialStructure : OneOf_PressureLossFunctionMediumPorousMaterialType, OneOf_DarcyMediumPorousMaterialType
{
    /// <summary>Schema name: DirectionalMaterialStructure</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DIRECTIONAL";

    [JsonPropertyName("mode")]
    public OneOf_DirectionalMaterialStructureMode? Mode { get; set; }

    [JsonPropertyName("direction")]
    public DimensionalVector_Dimensionless? Direction { get; set; }

    [JsonPropertyName("orientation")]
    public OneOf_DirectionalMaterialStructureOrientation? Orientation { get; set; }

}
