using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Defines how the box is created.</summary>
public class CreateBoxMethod
{
    /// <summary>Defines the parameter set used to define the box. It can be either: - `create-box-from-definition`, in which case the...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("box")]
    public BoxWithUnit? Box { get; set; }

    /// <summary>List of faces. This parameter is only valid for `create-box-from-faces` mode.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    /// <summary>Scaling factor to apply to the box, if none is provided the box will fit the input faces. This parameter is only vali...</summary>
    [JsonPropertyName("scaling_factor")]
    public double? ScalingFactor { get; set; }

}
