using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class SplitBodiesParameters
{
    /// <summary>Defines how the split plane is specified. It can be either: - `plane` (default if omitted), in which case the `plane`...</summary>
    [JsonPropertyName("split_mode")]
    public string? SplitMode { get; set; }

    [JsonPropertyName("plane")]
    public Plane? Plane { get; set; }

    /// <summary>Planar face whose plane specifies where the split occurs. Required in `face` mode, ignored in `plane` mode.</summary>
    [JsonPropertyName("face")]
    public string? Face { get; set; }

    /// <summary>If `true`, the normal of the selected face is reversed, so the other side is retained when `keep_both` is `false`. On...</summary>
    [JsonPropertyName("reverse_face_normal")]
    public bool? ReverseFaceNormal { get; set; }

    /// <summary>Controls the split. If `true`, both sides of the bodies are kept; otherwise, only the side facing the normal is retai...</summary>
    [JsonPropertyName("keep_both")]
    [JsonRequired]
    public required bool KeepBoth { get; set; }

    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

}
