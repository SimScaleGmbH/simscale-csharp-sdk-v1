using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class SubtractBodiesParameters
{
    /// <summary>List of target solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("targets")]
    public List<string>? Targets { get; set; }

    /// <summary>List of tool solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("tools")]
    public List<string>? Tools { get; set; }

    /// <summary>Controls the result. If `keep`, both parts if the target bodies are kept after the subtraction; otherwise, if `discar...</summary>
    [JsonPropertyName("keep_tools")]
    [JsonRequired]
    public required string KeepTools { get; set; }

}
