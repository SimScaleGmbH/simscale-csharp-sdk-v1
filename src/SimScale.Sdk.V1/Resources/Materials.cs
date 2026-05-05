using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.MaterialModels;

namespace SimScale.Sdk.V1.Resources;

public class Materials
{
    private readonly SimScaleClient _client;

    public Materials(SimScaleClient client) => _client = client;

    /// <summary>Create a new material</summary>
    public MaterialResponse CreateMaterial(
        string materialGroupId,
        CreateMaterialRequest body
    )
    {
        return _client.Request<MaterialResponse>(HttpMethod.Post, $"/materialgroups/{materialGroupId}/materials", body);
    }

    /// <summary>Create new material group</summary>
    public MaterialGroupResponse CreateMaterialGroup(
        CreateMaterialGroupRequest body
    )
    {
        return _client.Request<MaterialGroupResponse>(HttpMethod.Post, $"/materialgroups", body);
    }

    /// <summary>Create a child material group for the specified parent group</summary>
    public MaterialGroupResponse CreateNestedMaterialGroup(
        string materialGroupId,
        CreateNestedMaterialGroupRequest body
    )
    {
        return _client.Request<MaterialGroupResponse>(HttpMethod.Post, $"/materialgroups/{materialGroupId}/materialgroups", body);
    }

    /// <summary>Remove an existing material</summary>
    public void DeleteMaterialData(
        string materialGroupId,
        string materialId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/materialgroups/{materialGroupId}/materials/{materialId}");
    }

    /// <summary>Delete material group, sub-groups associated to it, and materials associated to the group and all sub-groups</summary>
    public void DeleteMaterialGroup(
        string materialGroupId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/materialgroups/{materialGroupId}");
    }

    /// <summary>Get information about an existing material</summary>
    public MaterialResponse GetMaterialData(
        string materialGroupId,
        string materialId
    )
    {
        return _client.Request<MaterialResponse>(HttpMethod.Get, $"/materialgroups/{materialGroupId}/materials/{materialId}");
    }

    /// <summary>Fetch material group information</summary>
    public MaterialGroupResponse GetMaterialGroupMetadata(
        string materialGroupId
    )
    {
        return _client.Request<MaterialGroupResponse>(HttpMethod.Get, $"/materialgroups/{materialGroupId}");
    }

    /// <summary>List all the material groups the user has access to</summary>
    public PaginatedResponse<MaterialGroupResponse> GetMaterialGroups(
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<MaterialGroupResponse>(HttpMethod.Get, $"/materialgroups",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>List materials within the material group</summary>
    public PaginatedResponse<MaterialResponse> GetMaterials(
        string materialGroupId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<MaterialResponse>(HttpMethod.Get, $"/materialgroups/{materialGroupId}/materials",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>List all sub-groups of the specified material group</summary>
    public PaginatedResponse<MaterialGroupResponse> GetNestedMaterialGroups(
        string materialGroupId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<MaterialGroupResponse>(HttpMethod.Get, $"/materialgroups/{materialGroupId}/materialgroups",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Update an existing material</summary>
    public MaterialResponse UpdateMaterialData(
        string materialGroupId,
        string materialId,
        CreateMaterialRequest body
    )
    {
        return _client.Request<MaterialResponse>(HttpMethod.Put, $"/materialgroups/{materialGroupId}/materials/{materialId}", body);
    }

    /// <summary>Update material group information</summary>
    public MaterialGroupResponse UpdateMaterialGroupMetadata(
        string materialGroupId,
        UpdateMaterialGroupRequest body
    )
    {
        return _client.Request<MaterialGroupResponse>(HttpMethod.Put, $"/materialgroups/{materialGroupId}", body);
    }
}
