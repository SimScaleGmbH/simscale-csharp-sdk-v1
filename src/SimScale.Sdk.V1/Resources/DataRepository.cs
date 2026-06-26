using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.DataRepositoryModels;

namespace SimScale.Sdk.V1.Resources;

public class DataRepository
{
    private readonly SimScaleClient _client;

    public DataRepository(SimScaleClient client) => _client = client;

    /// <summary>Cancel an append operation.</summary>
    public void CancelUploadSessionAppend(
        string storageId,
        string appendId,
        string? projectId = null
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/data-repository/data/upload-sessions/{storageId}/appends/{appendId}/cancel",
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Initialize an upload session backed by pre-signed URLs.</summary>
    public UploadSession CreateUploadSession(
        CreateUploadSessionRequest body,
        string? projectId = null
    )
    {
        return _client.Request<UploadSession>(HttpMethod.Post, $"/data-repository/data/upload-sessions", body,
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Delete an initialized upload session.</summary>
    public void DeleteUploadSession(
        string storageId,
        string? projectId = null
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/data-repository/data/upload-sessions/{storageId}",
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Download an existing data object. Streams the bytes of an internally-stored data object to the response body. The original `Content-Type` recorded at upload time is replayed on the response, sanitized against an allowlist for browser safety.</summary>
    public byte[] DownloadData(
        string dataId,
        string? filename = null
    )
    {
        return _client.RequestBytes(HttpMethod.Get, $"/data-repository/data/{dataId}/content",
            queryParams: new Dictionary<string, object?> { ["filename"] = filename });
    }

    /// <summary>Finalize an upload session and register it as data.</summary>
    public string FinalizeUploadSession(
        string storageId,
        string? projectId = null
    )
    {
        return _client.Request<string>(HttpMethod.Post, $"/data-repository/data/upload-sessions/{storageId}/finalize",
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Finish an append operation after the chunk was uploaded through its pre-signed URL.</summary>
    public void FinishUploadSessionAppend(
        string storageId,
        string appendId,
        string? projectId = null
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/data-repository/data/upload-sessions/{storageId}/appends/{appendId}/finish",
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Read the metadata of a data object.</summary>
    public DataInfo GetDataInfo(
        string dataId
    )
    {
        return _client.Request<DataInfo>(HttpMethod.Get, $"/data-repository/data/{dataId}");
    }

    /// <summary>List data objects in a project.</summary>
    public List<string> ListData(
        string projectId,
        string? origin = null,
        int? page = null,
        int? size = null,
        string? sortBy = null
    )
    {
        return _client.Request<List<string>>(HttpMethod.Get, $"/data-repository/projects/{projectId}/data",
            queryParams: new Dictionary<string, object?> { ["origin"] = origin, ["page"] = page, ["size"] = size, ["sortBy"] = sortBy });
    }

    /// <summary>Start appending a chunk to an initialized upload session.</summary>
    public UploadSessionAppend StartUploadSessionAppend(
        string storageId,
        StartUploadSessionAppendRequest body,
        string? projectId = null
    )
    {
        return _client.Request<UploadSessionAppend>(HttpMethod.Post, $"/data-repository/data/upload-sessions/{storageId}/appends", body,
            queryParams: new Dictionary<string, object?> { ["projectId"] = projectId });
    }

    /// <summary>Upload a new data object.</summary>
    public string UploadData(
        Stream content,
        string? dataType = null,
        string? projectId = null,
        string? contentType = null
    )
    {
        return _client.Request<string>(HttpMethod.Post, $"/data-repository/data", binaryBody: content, contentType: contentType,
            queryParams: new Dictionary<string, object?> { ["dataType"] = dataType, ["projectId"] = projectId });
    }
}
