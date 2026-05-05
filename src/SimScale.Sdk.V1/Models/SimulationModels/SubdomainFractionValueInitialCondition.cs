using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubdomainFractionValueInitialCondition
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("massFractions")]
    public List<FractionValueInitialCondition>? MassFractions { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
