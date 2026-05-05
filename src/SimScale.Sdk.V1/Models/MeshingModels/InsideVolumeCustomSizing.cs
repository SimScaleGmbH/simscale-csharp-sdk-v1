using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class InsideVolumeCustomSizing : OneOf_VolumeCustomSizingCustomSizingModes
{
    /// <summary>Schema name: InsideVolumeCustomSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INSIDE_CUSTOM_SIZING";

    [JsonPropertyName("sizing")]
    public OneOf_InsideVolumeCustomSizingSizing? Sizing { get; set; }

}
