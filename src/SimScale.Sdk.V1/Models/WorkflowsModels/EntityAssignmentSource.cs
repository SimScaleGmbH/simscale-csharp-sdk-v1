using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Entity assignment source is represented by its input data ID and its type (CAD or MESH).</summary>
public class EntityAssignmentSource
{
    [JsonPropertyName("inputDataName")]
    public string? InputDataName { get; set; }

    /// <summary>Source type is either CAD (model) or mesh.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

}
