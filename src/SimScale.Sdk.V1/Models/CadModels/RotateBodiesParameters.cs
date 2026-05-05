using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class RotateBodiesParameters
{
    /// <summary>List of solid regions and/or sheet bodies.</summary>
    [JsonPropertyName("occurrences")]
    public List<string>? Occurrences { get; set; }

    [JsonPropertyName("axis")]
    [JsonRequired]
    public required Axis Axis { get; set; }

    /// <summary>Angle or rotation in degrees.</summary>
    [JsonPropertyName("angle")]
    [JsonRequired]
    public required double Angle { get; set; }

    /// <summary>If this option is selected, the operation will create new bodies instead of modifying the selected ones.</summary>
    [JsonPropertyName("copy_bodies")]
    [JsonRequired]
    public required bool CopyBodies { get; set; }

}
