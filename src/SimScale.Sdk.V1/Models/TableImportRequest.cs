using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class TableImportRequest
{
    [JsonPropertyName("location")]
    [JsonRequired]
    public required TableImportRequestLocation Location { get; set; }

}
