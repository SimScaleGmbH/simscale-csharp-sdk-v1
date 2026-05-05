using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadImportRequest
{
    /// <summary>The name of the imported CAD.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("location")]
    [JsonRequired]
    public required CadImportRequestLocation Location { get; set; }

    /// <summary>The CAD format.</summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public required string Format { get; set; }

    [JsonPropertyName("inputUnit")]
    [JsonRequired]
    public required string InputUnit { get; set; }

    [JsonPropertyName("options")]
    [JsonRequired]
    public required CadImportRequestOptions Options { get; set; }

}
