using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FreeAxialTranslation : OneOf_PinKinematicBehaviorAxialTranslation
{
    /// <summary>Schema name: FreeAxialTranslation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FREE";

}
