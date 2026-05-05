using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class Table
{
    [JsonPropertyName("id")]
    [JsonRequired]
    public required Guid Id { get; set; }

    [JsonPropertyName("data")]
    [JsonRequired]
    public required TableData Data { get; set; }

}
