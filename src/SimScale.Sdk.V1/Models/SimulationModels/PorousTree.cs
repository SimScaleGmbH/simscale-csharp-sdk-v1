using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PorousTree : OneOf_AdvancedModellingPorousObjects
{
    /// <summary>Schema name: PorousTree</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POROUS_TREE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("treeType")]
    public OneOf_PorousTreeTreeType? TreeType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
