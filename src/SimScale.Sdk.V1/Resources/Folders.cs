using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Folders
{
    private readonly SimScaleClient _client;

    public Folders(SimScaleClient client) => _client = client;

    /// <summary>Create Folder Create a new Folder. If `parentFolderId` is missing, the folder will be created at the root level of the Space. Folder name clashes are allowed.</summary>
    public Folder CreateFolder(
        Guid spaceId,
        Folder body
    )
    {
        return _client.Request<Folder>(HttpMethod.Post, $"/spaces/{spaceId}/folders", body);
    }

    /// <summary>Delete Folder Delete a folder and all its content. The deletion is propagated to all child elements. If the total number of elements to delete is too large, this operation will be carried out asynchronously.</summary>
    public void DeleteFolder(
        Guid spaceId,
        Guid folderId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/spaces/{spaceId}/folders/{folderId}");
    }

    /// <summary>Get Folder Info Get Folder metadata and current user permissions.</summary>
    public Folder GetFolderInfo(
        Guid spaceId,
        Guid folderId
    )
    {
        return _client.Request<Folder>(HttpMethod.Get, $"/spaces/{spaceId}/folders/{folderId}");
    }

    /// <summary>List Folders in Folder List folders located in a Folder. Filtering or search capabilities are not supported. This only returns the folders of the queried folder, without a recursive expansion to child folders</summary>
    public PaginatedResponse<Folder> ListFoldersInFolder(
        Guid spaceId,
        Guid folderId,
        int? limit = null,
        int? page = null,
        string? sort = null
    )
    {
        return _client.RequestPaginated<Folder>(HttpMethod.Get, $"/spaces/{spaceId}/folders/{folderId}/content/folders",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["sort"] = sort });
    }

    /// <summary>List Folders in Space root List folders located at the root level of a Space. Filtering or search capabilities are not supported. This only returns the folders at the root level of a Space, without a recursive expansion to child folders.</summary>
    public PaginatedResponse<Folder> ListFoldersInSpaceRoot(
        Guid spaceId,
        int? limit = null,
        int? page = null,
        string? sort = null
    )
    {
        return _client.RequestPaginated<Folder>(HttpMethod.Get, $"/spaces/{spaceId}/content/folders",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["sort"] = sort });
    }

    /// <summary>List Projects in Folder List projects located in a Folder. Filtering or search capabilities are not supported. This only returns the projects of the queried folder, without a recursive expansion to child folders.</summary>
    public PaginatedResponse<Project> ListProjectsInFolder(
        Guid spaceId,
        Guid folderId,
        int? limit = null,
        int? page = null,
        string? sort = null
    )
    {
        return _client.RequestPaginated<Project>(HttpMethod.Get, $"/spaces/{spaceId}/folders/{folderId}/content/projects",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["sort"] = sort });
    }

    /// <summary>List Projects in Space root List projects located at the root level of a Space. Filtering or search capabilities are not supported. This only returns the projects at the root level of a Space, without a recursive expansion to child folders.</summary>
    public PaginatedResponse<Project> ListProjectsInSpaceRoot(
        Guid spaceId,
        int? limit = null,
        int? page = null,
        string? sort = null
    )
    {
        return _client.RequestPaginated<Project>(HttpMethod.Get, $"/spaces/{spaceId}/content/projects",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["sort"] = sort });
    }

    /// <summary>Move Content from Folder Move content from this folder. Several resources can be moved with the same request. All resources must be moved to the same target location. Folders cannot be moved to a different Space. Projects can only be moved to a Personal Space if the Space owner and the project owner match.</summary>
    public void MoveContentFromFolder(
        Guid spaceId,
        Guid folderId,
        MoveContentRequest body
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/spaces/{spaceId}/folders/{folderId}/move", body);
    }

    /// <summary>Move Content from Space root Move content located at the root level of a Space. Several resources can be moved with the same request. All resources must be moved to the same target location. Folders cannot be moved to a different Space. Projects can only be moved to a Personal Space if the Space owner and the project owner match.</summary>
    public void MoveContentFromSpaceRoot(
        Guid spaceId,
        MoveContentRequest body
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/spaces/{spaceId}/move", body);
    }

    /// <summary>Update Folder Update Folder metadata</summary>
    public Folder UpdateFolder(
        Guid spaceId,
        Guid folderId,
        Folder body
    )
    {
        return _client.Request<Folder>(HttpMethod.Put, $"/spaces/{spaceId}/folders/{folderId}", body);
    }
}
