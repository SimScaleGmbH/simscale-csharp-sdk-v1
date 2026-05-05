using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Storage
{
    /// <summary>The URL of the temporary storage location.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The storage ID.</summary>
    [JsonPropertyName("storageId")]
    public string? StorageId { get; set; }

    /// <summary>The expiration time.</summary>
    [JsonPropertyName("expiresAt")]
    public DateTimeOffset? ExpiresAt { get; set; }

}
