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

    /// <summary>Controls whether the tool bodies are retained after the subtraction. If `keep`, the tool bodies are kept alongside th...</summary>
    [JsonPropertyName("keep_tools")]
    [JsonRequired]
    public required string KeepTools { get; set; }

}
