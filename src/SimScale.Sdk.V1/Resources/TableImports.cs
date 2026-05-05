using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class TableImports
{
    private readonly SimScaleClient _client;

    public TableImports(SimScaleClient client) => _client = client;

    /// <summary>Import a new table for reference within a Simulation spec Table import requires the following steps: 1. Request a temporary storage location via `POST /storage`. 2. Upload your table definition using the HTTP `PUT` method to the `url` provided in the temporary storage location response object. 3. Import via `POST /projects/{projectId}/tableimports` and include the `storageId` provided in the temporary storage location response object.</summary>
    public TableImportResponse ImportTable(
        string projectId,
        TableImportRequest body
    )
    {
        return _client.Request<TableImportResponse>(HttpMethod.Post, $"/projects/{projectId}/tableimports", body);
    }
}
