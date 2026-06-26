using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>(A single-select) entity assignment from an arbitrary source (CAD/Mesh).</summary>
public class EntityAssignment
{
    [JsonPropertyName("entity")]
    public string? Entity { get; set; }

    [JsonPropertyName("savedSelection")]
    public string? SavedSelection { get; set; }

    [JsonPropertyName("source")]
    public EntityAssignmentSource? Source { get; set; }

}
