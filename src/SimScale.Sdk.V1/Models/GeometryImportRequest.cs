using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class GeometryImportRequest
{
    /// <summary>The name of the imported geometry.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("location")]
    [JsonRequired]
    public required JsonElement Location { get; set; }

    /// <summary>The CAD format.</summary>
    [JsonPropertyName("format")]
    [JsonRequired]
    public required string Format { get; set; }

    [JsonPropertyName("inputUnit")]
    [JsonRequired]
    public required string InputUnit { get; set; }

    /// <summary>CAD import options. Please refer to https://www.simscale.com/docs/cad-preparation/#cad-upload-options for a detailed...</summary>
    [JsonPropertyName("options")]
    [JsonRequired]
    public required JsonElement Options { get; set; }

}
