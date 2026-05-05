using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class SimplifyParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    /// <summary>Type of body used in the simplification. It can be either: `box`, or `cylinder`.</summary>
    [JsonPropertyName("primitive")]
    [JsonRequired]
    public required string Primitive { get; set; }

    /// <summary>Controls the result. If `true`, each body will be replaced singularly; otherwise all bodies will be replaced by a sin...</summary>
    [JsonPropertyName("replace_each")]
    [JsonRequired]
    public required bool ReplaceEach { get; set; }

}
