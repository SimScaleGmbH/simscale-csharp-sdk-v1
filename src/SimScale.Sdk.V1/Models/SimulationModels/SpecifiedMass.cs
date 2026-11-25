using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecifiedMass : OneOf_ComputedTranslationalMotionMassDefinition
{
    /// <summary>Schema name: SpecifiedMass</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIED_MASS";

    [JsonPropertyName("mass")]
    public Dimensional_Mass? Mass { get; set; }

}
