using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class CadImports
{
    private readonly SimScaleClient _client;

    public CadImports(SimScaleClient client) => _client = client;

    /// <summary>Get the CAD import event log</summary>
    public EventLogResponse GetCadImportEventLog(
        string projectId,
        Guid cadId
    )
    {
        return _client.Request<EventLogResponse>(HttpMethod.Get, $"/projects/{projectId}/cadimports/{cadId}/eventlog");
    }

    /// <summary>Get information about the imported CAD</summary>
    public CadImportResponse GetImportedCad(
        string projectId,
        Guid cadId
    )
    {
        return _client.Request<CadImportResponse>(HttpMethod.Get, $"/projects/{projectId}/cadimports/{cadId}");
    }

    /// <summary>Import a new CAD from file CAD import requires the following steps: 1. Request a temporary storage location via `POST /storage`. 2. Upload your CAD file using the HTTP `PUT` method to the `url` provided in the temporary storage location response object. 3. Start the import via `POST /projects/{projectId}/cadimports` and include the `storageId` provided in the temporary storage location response object. 4. Check for the import status via `GET /projects/{projectId}/cadimports/{cadId}`.</summary>
    public CadImportResponse ImportCad(
        string projectId,
        CadImportRequest body
    )
    {
        return _client.Request<CadImportResponse>(HttpMethod.Post, $"/projects/{projectId}/cadimports", body);
    }
}
