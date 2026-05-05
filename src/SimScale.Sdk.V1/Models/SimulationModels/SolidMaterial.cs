using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidMaterial
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("materialBehavior")]
    public OneOf_SolidMaterialMaterialBehavior? MaterialBehavior { get; set; }

    [JsonPropertyName("density")]
    public DimensionalFunction_Density? Density { get; set; }

    [JsonPropertyName("expansion")]
    public IsotropicExpansion? Expansion { get; set; }

    [JsonPropertyName("conductivity")]
    public OneOf_SolidMaterialConductivity? Conductivity { get; set; }

    [JsonPropertyName("specificHeat")]
    public DimensionalFunction_SpecificHeat? SpecificHeat { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("builtInMaterial")]
    public string? BuiltInMaterial { get; set; }

    [JsonPropertyName("materialLibraryReference")]
    public MaterialLibraryReference? MaterialLibraryReference { get; set; }

}
