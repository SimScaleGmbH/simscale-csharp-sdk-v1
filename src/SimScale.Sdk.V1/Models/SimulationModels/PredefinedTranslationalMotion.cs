using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PredefinedTranslationalMotion : OneOf_ElectromagneticMotionMotion
{
    /// <summary>Schema name: PredefinedTranslationalMotion</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PREDEFINED_TRANSLATIONAL_MOTION";

    [JsonPropertyName("velocity")]
    public DimensionalVectorFunction_Speed? Velocity { get; set; }

}
