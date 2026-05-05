using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcMaterial
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("marcMaterialBehavior")]
    public OneOf_MarcMaterialMarcMaterialBehavior? MarcMaterialBehavior { get; set; }

    [JsonPropertyName("density")]
    public DimensionalFunction_Density? Density { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("builtInMaterial")]
    public string? BuiltInMaterial { get; set; }

    [JsonPropertyName("materialLibraryReference")]
    public MaterialLibraryReference? MaterialLibraryReference { get; set; }

}
