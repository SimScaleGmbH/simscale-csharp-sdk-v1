using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class TableImportResponse
{
    /// <summary>The ID of the imported table.</summary>
    [JsonPropertyName("tableId")]
    [JsonRequired]
    public required Guid TableId { get; set; }

}
