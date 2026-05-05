using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomElementDefinitionMethod : OneOf_ElementTechnologyDefinitionMethod
{
    /// <summary>Schema name: CustomElementDefinitionMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("mechanicalMeshElementOrder")]
    public string? MechanicalMeshElementOrder { get; set; }

    [JsonPropertyName("thermalMeshElementOrder")]
    public string? ThermalMeshElementOrder { get; set; }

    [JsonPropertyName("reducedIntegration")]
    public bool? ReducedIntegration { get; set; }

    [JsonPropertyName("lumpedMass")]
    public bool? LumpedMass { get; set; }

    [JsonPropertyName("definitions")]
    public List<ElementTechnologyDefinition>? Definitions { get; set; }

}
