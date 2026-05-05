using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FreeAxialRotation : OneOf_PinKinematicBehaviorRotation
{
    /// <summary>Schema name: FreeAxialRotation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FREE";

}
