using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VectorRotation : OneOf_RotatingMotionTypeRotation, OneOf_RotatingSBMRotation
{
    /// <summary>Schema name: VectorRotation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VECTOR_ROTATION";

    [JsonPropertyName("rotationCenter")]
    public DimensionalVector_Length? RotationCenter { get; set; }

    [JsonPropertyName("angularVelocity")]
    public DimensionalVector_RotationSpeed? AngularVelocity { get; set; }

}
