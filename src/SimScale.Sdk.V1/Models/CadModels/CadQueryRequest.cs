using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CadQueryRequest
{
    /// <summary>Available query types: - `detect-contacts-v3`: Identify contacts between solid regions. Supported internal formats: `...</summary>
    [JsonPropertyName("query")]
    [JsonRequired]
    public required string Query { get; set; }

    [JsonPropertyName("parameters")]
    public JsonElement? Parameters { get; set; }

}
