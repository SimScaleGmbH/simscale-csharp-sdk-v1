using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Permissions that the current user has on this Space. Each flag corresponds to a fine-grained action that a user may take.</summary>
public class SpacePermissions
{
    /// <summary>Whether the current user can list the contents of the root of this Space.</summary>
    [JsonPropertyName("canListContentInRoot")]
    public bool? CanListContentInRoot { get; set; }

    /// <summary>Whether the current user can create new content in the root of this Space.</summary>
    [JsonPropertyName("canCreateContentInRoot")]
    public bool? CanCreateContentInRoot { get; set; }

    /// <summary>Whether the current user can move content into the root folder of this Space.</summary>
    [JsonPropertyName("canMoveContentToRoot")]
    public bool? CanMoveContentToRoot { get; set; }

    /// <summary>Whether the current user can move content out of the root folder of this Space.</summary>
    [JsonPropertyName("canMoveContentOutOfRoot")]
    public bool? CanMoveContentOutOfRoot { get; set; }

    /// <summary>Whether the current user can edit the metadata of this Space.</summary>
    [JsonPropertyName("canEditSpaceMetadata")]
    public bool? CanEditSpaceMetadata { get; set; }

    /// <summary>Whether the current user can edit the settings of this Space.</summary>
    [JsonPropertyName("canEditSpaceSettings")]
    public bool? CanEditSpaceSettings { get; set; }

    /// <summary>Whether the current user can add or remove users to this Space.</summary>
    [JsonPropertyName("canEditSpacePermissions")]
    public bool? CanEditSpacePermissions { get; set; }

    /// <summary>Whether the current user can delete this Space.</summary>
    [JsonPropertyName("canDeleteSpace")]
    public bool? CanDeleteSpace { get; set; }

}
