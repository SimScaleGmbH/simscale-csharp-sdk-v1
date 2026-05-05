using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Mesh
{
    /// <summary>The ID of the mesh.</summary>
    [JsonPropertyName("meshId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid MeshId { get; set; }

    /// <summary>The name of the mesh.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time when the mesh was imported.</summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Number of cells of the mesh.</summary>
    [JsonPropertyName("numberOfCells")]
    public int? NumberOfCells { get; set; }

    /// <summary>Number of nodes of the mesh.</summary>
    [JsonPropertyName("numberOfNodes")]
    public int? NumberOfNodes { get; set; }

}
