using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RigidAxialTranslation : OneOf_PinKinematicBehaviorAxialTranslation
{
    /// <summary>Schema name: RigidAxialTranslation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RIGID";

}
