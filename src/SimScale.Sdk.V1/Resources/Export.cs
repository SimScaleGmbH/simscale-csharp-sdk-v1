using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Export
{
    private readonly SimScaleClient _client;

    public Export(SimScaleClient client) => _client = client;

    /// <summary>Trigger an export for a simulation result</summary>
    public CreateExportResponse CreateExport(
        string projectId,
        CreateExportRequest body
    )
    {
        return _client.Request<CreateExportResponse>(HttpMethod.Post, $"/projects/{projectId}/export", body);
    }

    /// <summary>Get the status of the export and temporary download link to the exported object if it is done</summary>
    public GetExportResponse GetExport(
        string projectId,
        Guid exportId
    )
    {
        return _client.Request<GetExportResponse>(HttpMethod.Get, $"/projects/{projectId}/export/{exportId}");
    }
}
