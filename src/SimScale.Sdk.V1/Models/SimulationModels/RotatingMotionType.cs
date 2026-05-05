using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RotatingMotionType : OneOf_AMIRotatingZoneMotionType
{
    /// <summary>Schema name: RotatingMotionType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ROTATING_MOTION";

    [JsonPropertyName("rotation")]
    public OneOf_RotatingMotionTypeRotation? Rotation { get; set; }

}
