using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ComputedTranslationalMotion : OneOf_ElectromagneticMotionMotion
{
    /// <summary>Schema name: ComputedTranslationalMotion</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COMPUTED_TRANSLATIONAL_MOTION";

    [JsonPropertyName("massDefinition")]
    public OneOf_ComputedTranslationalMotionMassDefinition? MassDefinition { get; set; }

    [JsonPropertyName("motionAxis")]
    public MotionAxis? MotionAxis { get; set; }

    [JsonPropertyName("externalForces")]
    public ExternalForces? ExternalForces { get; set; }

}
