using System.Net.Http.Headers;
using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.DataRepositoryModels;
using SimScale.Sdk.V1.Models.MaterialModels;

namespace SimScale.Sdk.V1;

public partial class SimScaleSDK
{
    private const long DefaultUploadSessionChunkSize = 2_000_000_000L;
    private const int UploadBufferSize = 8 * 1024 * 1024;

    private static readonly string[] DefaultTerminalStatuses = ["FINISHED", "SUCCEEDED", "CANCELED", "FAILED", "DONE", "EXPIRED"];
    private static readonly string[] DefaultSuccessStatuses = ["FINISHED", "SUCCEEDED", "DONE"];

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

    /// <summary>
    /// Upload a file to data-repository and return its DataId.
    /// </summary>
    /// <param name="filepath">Path to the file to upload.</param>
    /// <param name="projectId">Project where the data will be stored.</param>
    /// <param name="dataType">Workflow data type reference for the uploaded data.</param>
    /// <param name="contentType">Content type stored with the uploaded data.</param>
    /// <param name="chunkSize">Maximum append size in bytes. Defaults to 2,000,000,000 bytes (2 GB), matching the direct upload limit.</param>
    public string UploadToDataRepository(
        string filepath,
        string projectId,
        string dataType,
        string contentType = "application/octet-stream",
        long chunkSize = DefaultUploadSessionChunkSize)
    {
        if (chunkSize <= 0)
            throw new ArgumentException("chunkSize must be greater than zero", nameof(chunkSize));

        var fileInfo = new FileInfo(filepath);
        if (fileInfo.Length == 0)
            throw new ArgumentException("upload sessions require a non-empty file", nameof(filepath));

        var uploadSession = DataRepository.CreateUploadSession(
            new CreateUploadSessionRequest
            {
                DataType = dataType,
                ContentType = contentType,
            },
            projectId);
        var storageId = uploadSession.StorageId
            ?? throw new InvalidOperationException("Upload session response did not contain StorageId");

        try
        {
            using var file = File.OpenRead(filepath);
            var offset = 0L;
            while (offset < fileInfo.Length)
            {
                var currentChunkSize = Math.Min(chunkSize, fileInfo.Length - offset);
                var append = DataRepository.StartUploadSessionAppend(
                    storageId,
                    new StartUploadSessionAppendRequest
                    {
                        Size = currentChunkSize,
                    },
                    projectId);
                var appendId = append.AppendId
                    ?? throw new InvalidOperationException("Upload session append response did not contain AppendId");

                try
                {
                    UploadFileRangeToPresignedRequest(append.PreSignedPutRequest, file, currentChunkSize);
                    DataRepository.FinishUploadSessionAppend(storageId, appendId, projectId);
                }
                catch
                {
                    try
                    {
                        DataRepository.CancelUploadSessionAppend(storageId, appendId, projectId);
                    }
                    catch
                    {
                        // Keep the original upload failure visible to the caller.
                    }
                    throw;
                }

                offset += currentChunkSize;
            }

            return DataRepository.FinalizeUploadSession(storageId, projectId);
        }
        catch
        {
            try
            {
                DataRepository.DeleteUploadSession(storageId, projectId);
            }
            catch
            {
                // Keep the original upload failure visible to the caller.
            }
            throw;
        }
    }

    /// <summary>
    /// Create a workflow data map for workflows without parameter values.
    /// Workflow data maps support parameter-value combinations. For non-parametric
    /// data there is one combination with empty parameter values; its UUID only
    /// links both sections of this serialized data map.
    /// </summary>
    public JsonElement CreateNonParametricWorkflowDataMap(IReadOnlyDictionary<string, string> dataByName)
    {
        var parameterValueCombinationId = Guid.NewGuid().ToString();
        var payload = new
        {
            parameterValueCombinationsById = new Dictionary<string, object>
            {
                [parameterValueCombinationId] = new
                {
                    parameterValues = new Dictionary<string, object>(),
                },
            },
            dataByNameAndParameterValueCombinationId = dataByName.ToDictionary(
                item => item.Key,
                item => new Dictionary<string, string>
                {
                    [parameterValueCombinationId] = item.Value,
                }),
        };

        return JsonSerializer.SerializeToElement(payload, SimScaleClient.JsonOptions);
    }

    /// <summary>
    /// Read a data ID from a workflow data map without parameter values.
    /// </summary>
    public string? GetNonParametricWorkflowDataId(JsonElement? dataMap, string dataName)
    {
        if (dataMap is null)
            return null;

        if (!dataMap.Value.TryGetProperty("dataByNameAndParameterValueCombinationId", out var dataByNameElement))
            return null;

        if (!dataByNameElement.TryGetProperty(dataName, out var dataByParameterId))
            return null;

        foreach (var property in dataByParameterId.EnumerateObject())
        {
            if (property.Value.ValueKind == JsonValueKind.String)
                return property.Value.GetString();
        }

        return null;
    }

    private static void UploadFileRangeToPresignedRequest(PresignedRequest? presignedRequest, FileStream file, long size)
    {
        var url = presignedRequest?.Url
            ?? throw new InvalidOperationException("Upload session append response did not contain a pre-signed PUT URL");

        using var http = new HttpClient
        {
            Timeout = TimeSpan.FromHours(1),
        };
        using var limitedStream = new LimitedReadStream(file, size);
        using var content = new StreamContent(limitedStream, UploadBufferSize);
        content.Headers.ContentLength = size;

        using var request = new HttpRequestMessage(HttpMethod.Put, url)
        {
            Content = content,
        };
        request.Headers.UserAgent.ParseAdd(SimScaleClient.UserAgent);

        foreach (var header in presignedRequest?.Headers ?? [])
        {
            if (string.IsNullOrWhiteSpace(header.Name) || header.Value is null)
                continue;

            if (header.Name.Equals("Content-Length", StringComparison.OrdinalIgnoreCase))
                continue;

            if (header.Name.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
                content.Headers.TryAddWithoutValidation(header.Name, header.Value);
            else
                request.Headers.TryAddWithoutValidation(header.Name, header.Value);
        }

        using var response = http.Send(request);
        if (!response.IsSuccessStatusCode)
            throw new SimScaleAPIError(
                (int)response.StatusCode,
                response.Content.ReadAsStringAsync().GetAwaiter().GetResult(),
                url);
    }

    private sealed class LimitedReadStream : Stream
    {
        private readonly Stream _inner;
        private long _remaining;

        public LimitedReadStream(Stream inner, long size)
        {
            _inner = inner;
            _remaining = size;
        }

        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();

        public override long Position
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }

        public override void Flush() { }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_remaining <= 0)
                return 0;

            var bytesToRead = (int)Math.Min(count, _remaining);
            var bytesRead = _inner.Read(buffer, offset, bytesToRead);
            _remaining -= bytesRead;
            return bytesRead;
        }

        public override int Read(Span<byte> buffer)
        {
            if (_remaining <= 0)
                return 0;

            var bytesToRead = (int)Math.Min(buffer.Length, _remaining);
            var bytesRead = _inner.Read(buffer[..bytesToRead]);
            _remaining -= bytesRead;
            return bytesRead;
        }

        public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            if (_remaining <= 0)
                return 0;

            var bytesToRead = (int)Math.Min(buffer.Length, _remaining);
            var bytesRead = await _inner.ReadAsync(buffer[..bytesToRead], cancellationToken);
            _remaining -= bytesRead;
            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    }
}
