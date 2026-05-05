using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class TableImportRequestLocation
{
    /// <summary>The storage ID of the temporary storage location where the table has been uploaded.</summary>
    [JsonPropertyName("storageId")]
    [JsonRequired]
    public required string StorageId { get; set; }

}
