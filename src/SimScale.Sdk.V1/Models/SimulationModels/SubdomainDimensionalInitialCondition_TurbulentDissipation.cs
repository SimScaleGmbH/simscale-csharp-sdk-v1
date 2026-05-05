using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubdomainDimensionalInitialCondition_TurbulentDissipation
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("subdomainValue")]
    public Dimensional_TurbulentDissipation? SubdomainValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
