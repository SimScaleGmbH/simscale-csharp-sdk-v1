using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Defines how the box is created.</summary>
public class CreateBoxMethod
{
    /// <summary>Defines how the box should be created. It can be either: - `create-box-from-definition`, in which case the `box` para...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("box")]
    public BoxWithUnit? Box { get; set; }

    /// <summary>List of faces used to fit the box. This parameter is only valid for `create-box-from-faces` mode.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    /// <summary>Optional scale factor applied to the fitted box. If omitted, the box fits the selected faces. This parameter is only...</summary>
    [JsonPropertyName("scaling_factor")]
    public double? ScalingFactor { get; set; }

}
