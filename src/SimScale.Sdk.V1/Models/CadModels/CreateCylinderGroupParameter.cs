using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class CreateCylinderGroupParameter
{
    /// <summary>Defines the parameter set used to define the cylinder. It can be either: - `create-cylinder-from-definition`, in whic...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    /// <summary>List of faces. This parameter is only valid for `create-cylinder-from-faces` mode.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    /// <summary>Scaling factor to apply to the radius of the cylinder, if none is provided the radius will fit the input faces. This...</summary>
    [JsonPropertyName("radial_clearance_factor")]
    public double? RadialClearanceFactor { get; set; }

    /// <summary>Scaling factor to apply to the height of the cylinder, if none is provided the height will fit the input faces. This...</summary>
    [JsonPropertyName("height_clearance_factor")]
    public double? HeightClearanceFactor { get; set; }

    [JsonPropertyName("cylinder")]
    public Cylinder? Cylinder { get; set; }

}
