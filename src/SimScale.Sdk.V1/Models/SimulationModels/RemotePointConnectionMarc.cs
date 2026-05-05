using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RemotePointConnectionMarc
{
    /// <summary>Schema name: RemotePointConnectionMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REMOTE_POINT_CONNECTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Behavior: Create a connector between a remote point and a set of entities of the model. The remote point can then be...</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Create or select the point geometry primitive which should be connected to the assigned surfaces, volumes or edges vi...</summary>
    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
