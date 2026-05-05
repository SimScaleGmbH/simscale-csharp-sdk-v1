using System.Net.Http.Headers;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.MaterialModels;

namespace SimScale.Sdk.V1;

public partial class SimScaleSDK
{
    private static readonly string[] DefaultTerminalStatuses = ["FINISHED", "CANCELED", "FAILED", "DONE", "EXPIRED"];
    private static readonly string[] DefaultSuccessStatuses = ["FINISHED", "DONE"];

    /// <summary>
    /// Poll until status reaches a terminal state.
    /// Raises <see cref="SimScaleOperationError"/> if the operation fails (unless raiseOnFailure is false).
    /// Raises <see cref="TimeoutException"/> if timeout is exceeded.
    /// </summary>
    /// <param name="poll">Function that fetches the current state of the operation.</param>
    /// <param name="getStatus">Function that extracts the status string from the result.</param>
    /// <param name="timeoutSeconds">Maximum time to wait in seconds (default 3600).</param>
    /// <param name="intervalMs">Polling interval in milliseconds (default 30000).</param>
    /// <param name="terminalStatuses">Statuses that indicate the operation is done.</param>
    /// <param name="successStatuses">Statuses that indicate success. Others cause an error if raiseOnFailure is true.</param>
    /// <param name="raiseOnFailure">If true, throw SimScaleOperationError when status is terminal but not success.</param>
    public T WaitUntilDone<T>(
        Func<T> poll,
        Func<T, string?> getStatus,
        int timeoutSeconds = 3600,
        int intervalMs = 30_000,
        string[]? terminalStatuses = null,
        string[]? successStatuses = null,
        bool raiseOnFailure = true)
    {
        terminalStatuses ??= DefaultTerminalStatuses;
        successStatuses ??= DefaultSuccessStatuses;

        var start = DateTime.UtcNow;
        var result = poll();
        while (!terminalStatuses.Contains(getStatus(result)))
        {
            if ((DateTime.UtcNow - start).TotalSeconds > timeoutSeconds)
                throw new TimeoutException($"Timed out after {timeoutSeconds}s (last status: {getStatus(result)})");
            Thread.Sleep(intervalMs);
            result = poll();
        }

        if (raiseOnFailure && !successStatuses.Contains(getStatus(result)))
            throw new SimScaleOperationError(result!, getStatus(result));

        return result;
    }

    /// <summary>
    /// Look up a material by name from the SimScale material library.
    /// Uses the SimScale default material group unless a specific group name is provided.
    /// </summary>
    public MaterialResponse GetMaterial(string name, string? group = null)
    {
        var groups = Materials.GetMaterialGroups(limit: 100).Embedded;

        MaterialGroupResponse materialGroup;
        if (group != null)
        {
            materialGroup = groups.FirstOrDefault(g => g.Name == group)
                ?? throw new InvalidOperationException(
                    $"Material group '{group}' not found. Available: {string.Join(", ", groups.Select(g => g.Name))}");
        }
        else
        {
            materialGroup = groups.FirstOrDefault(g => g.GroupType == MaterialGroupType.SimscaleDefault)
                ?? throw new InvalidOperationException("Could not find the SimScale default material group");
        }

        var materials = Materials.GetMaterials(materialGroup.MaterialGroupId, limit: 100).Embedded;
        var material = materials.FirstOrDefault(m => m.Name == name)
            ?? throw new InvalidOperationException(
                $"Material '{name}' not found. Available: {string.Join(", ", materials.Select(m => m.Name))}");

        return Materials.GetMaterialData(materialGroup.MaterialGroupId, material.Id);
    }

    /// <summary>
    /// Create a storage entry and upload a file. Returns the Storage object (use .StorageId).
    /// </summary>
    public Models.Storage Upload(string filepath)
    {
        var storage = Storage.CreateStorage();

        using var fileStream = File.OpenRead(filepath);
        using var content = new StreamContent(fileStream);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

        using var http = new HttpClient();
        http.DefaultRequestHeaders.UserAgent.ParseAdd(SimScaleClient.UserAgent);
        using var response = http.PutAsync(storage.Url, content).GetAwaiter().GetResult();
        if (!response.IsSuccessStatusCode)
            throw new SimScaleAPIError(
                (int)response.StatusCode,
                response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        return storage;
    }

    /// <summary>
    /// Download a file from a URL to a local path.
    /// </summary>
    public void Download(string url, string filepath)
    {
        using var http = new HttpClient();
        http.DefaultRequestHeaders.UserAgent.ParseAdd(SimScaleClient.UserAgent);
        using var response = http.GetAsync(url).GetAwaiter().GetResult();
        if (!response.IsSuccessStatusCode)
            throw new SimScaleAPIError(
                (int)response.StatusCode,
                response.Content.ReadAsStringAsync().GetAwaiter().GetResult());

        using var stream = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
        using var fileOut = File.Create(filepath);
        stream.CopyTo(fileOut);
    }
}
