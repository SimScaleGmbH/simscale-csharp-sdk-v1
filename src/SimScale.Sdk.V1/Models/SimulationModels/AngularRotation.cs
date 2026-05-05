using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AngularRotation : OneOf_RotatingSBMRotation, OneOf_RotatingMotionTypeRotation
{
    /// <summary>Schema name: AngularRotation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ANGULAR_ROTATION";

    [JsonPropertyName("rotationCenter")]
    public DimensionalVector_Length? RotationCenter { get; set; }

    [JsonPropertyName("rotationAxis")]
    public DimensionalVector_Length? RotationAxis { get; set; }

    [JsonPropertyName("angularVelocity")]
    public DimensionalFunction_RotationSpeed? AngularVelocity { get; set; }

}
