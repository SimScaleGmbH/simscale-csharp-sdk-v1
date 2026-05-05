using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Project
{
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Always returned by the backend. Optional at project creation. If missing, the project will be created in the Personal...</summary>
    [JsonPropertyName("spaceId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid SpaceId { get; set; }

    /// <summary>If missing, the project is located at the root level of the Space.</summary>
    [JsonPropertyName("parentFolderId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ParentFolderId { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>The project title should contain the application you want to analyze as well as the simulation method you want to use...</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>A meaningful description of the project.</summary>
    [JsonPropertyName("description")]
    [JsonRequired]
    public required string Description { get; set; }

    /// <summary>The measurement system of the project. Can't be modified.</summary>
    [JsonPropertyName("measurementSystem")]
    public string MeasurementSystem { get; set; } = "SI";

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

}
