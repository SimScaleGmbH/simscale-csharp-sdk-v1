using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Specify the resource to be moved. One of `folderId` or `projectId` must be defined. An error is returned if both fields are passed.</summary>
public class ResourceToMove
{
    /// <summary>Use this field to move an entire folder</summary>
    [JsonPropertyName("folderId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid FolderId { get; set; }

    /// <summary>Use this field to move a project</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

}
