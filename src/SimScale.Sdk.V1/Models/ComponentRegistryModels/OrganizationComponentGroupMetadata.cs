using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Metadata of an organization component group.</summary>
public class OrganizationComponentGroupMetadata
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a component group. Components are organized into a group hierarchy which serves as a qualification mecha...</summary>
    [JsonPropertyName("organizationComponentGroupReference")]
    public string? OrganizationComponentGroupReference { get; set; }

    [JsonPropertyName("organizationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid OrganizationId { get; set; }

}
