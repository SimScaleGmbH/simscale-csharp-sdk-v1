using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class SplitBodiesParameters
{
    [JsonPropertyName("plane")]
    [JsonRequired]
    public required Plane Plane { get; set; }

    /// <summary>Controls the split. If `true`, both sides of the bodies are kept; otherwise, only the side facing the normal is retai...</summary>
    [JsonPropertyName("keep_both")]
    [JsonRequired]
    public required bool KeepBoth { get; set; }

    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

}
