using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Space
{
    [JsonPropertyName("spaceId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid SpaceId { get; set; }

    /// <summary>Only present for Team Spaces</summary>
    [JsonPropertyName("organizationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid OrganizationId { get; set; }

    /// <summary>Only present for Personal Spaces</summary>
    [JsonPropertyName("ownerUsername")]
    public string? OwnerUsername { get; set; }

    [JsonPropertyName("spaceType")]
    public string? SpaceType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public DateTimeOffset? LastModifiedAt { get; set; }

    [JsonPropertyName("spaceSettings")]
    public SpaceSettings? SpaceSettings { get; set; }

}
