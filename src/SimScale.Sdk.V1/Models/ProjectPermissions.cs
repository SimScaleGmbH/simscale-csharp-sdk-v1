using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Permissions that the current user has on this Project. Each flag corresponds to a fine-grained action that a user may take.</summary>
public class ProjectPermissions
{
    /// <summary>Whether the current user can see basic details about this Project.</summary>
    [JsonPropertyName("canPreviewProject")]
    public bool? CanPreviewProject { get; set; }

    /// <summary>Whether the current user can open this Project.</summary>
    [JsonPropertyName("canReadProject")]
    public bool? CanReadProject { get; set; }

    /// <summary>Whether the current user can copy this Project.</summary>
    [JsonPropertyName("canCopyProject")]
    public bool? CanCopyProject { get; set; }

    /// <summary>Whether the current user can edit this Project.</summary>
    [JsonPropertyName("canWriteProject")]
    public bool? CanWriteProject { get; set; }

    /// <summary>Whether the current user can execute a billable action on this Project.</summary>
    [JsonPropertyName("canExecuteProjectBillableAction")]
    public bool? CanExecuteProjectBillableAction { get; set; }

    /// <summary>Whether the current user can manage this Project.</summary>
    [JsonPropertyName("canManageProject")]
    public bool? CanManageProject { get; set; }

    /// <summary>Whether the current user can move this Project to their Personal Space.</summary>
    [JsonPropertyName("canMoveProjectToPersonalSpace")]
    public bool? CanMoveProjectToPersonalSpace { get; set; }

    /// <summary>Whether the current user can see who has access to this Project.</summary>
    [JsonPropertyName("canListProjectPermissions")]
    public bool? CanListProjectPermissions { get; set; }

    /// <summary>Whether the current user can change who has access to this Project.</summary>
    [JsonPropertyName("canEditProjectPermissions")]
    public bool? CanEditProjectPermissions { get; set; }

    /// <summary>Whether the current user can share this project with users that have access to the Space.</summary>
    [JsonPropertyName("canShareProjectWithSpaceMembers")]
    public bool? CanShareProjectWithSpaceMembers { get; set; }

    /// <summary>Whether the current user can share this project with members of the Organization.</summary>
    [JsonPropertyName("canShareProjectWithOrganizationMembers")]
    public bool? CanShareProjectWithOrganizationMembers { get; set; }

    /// <summary>Whether the current user can share this project with any user of the platform.</summary>
    [JsonPropertyName("canShareProjectWithAnyone")]
    public bool? CanShareProjectWithAnyone { get; set; }

    /// <summary>Whether the current user can make this project public.</summary>
    [JsonPropertyName("canMakeProjectPublic")]
    public bool? CanMakeProjectPublic { get; set; }

    /// <summary>Whether the current user can delete this Project.</summary>
    [JsonPropertyName("canDeleteProject")]
    public bool? CanDeleteProject { get; set; }

}
