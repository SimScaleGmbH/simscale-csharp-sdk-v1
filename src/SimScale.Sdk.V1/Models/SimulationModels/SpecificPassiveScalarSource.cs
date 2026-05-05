using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecificPassiveScalarSource : OneOf_AdvancedConceptsPassiveScalarSources
{
    /// <summary>Schema name: SpecificPassiveScalarSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIC";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("passiveScalarVariable")]
    public string? PassiveScalarVariable { get; set; }

    [JsonPropertyName("flux")]
    public Dimensional_VolumetricPassiveScalarSourceRate? Flux { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
