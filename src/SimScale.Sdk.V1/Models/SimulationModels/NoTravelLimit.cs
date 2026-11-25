using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoTravelLimit : OneOf_MotionAxisTravelLimit
{
    /// <summary>Schema name: NoTravelLimit</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_TRAVEL_LIMIT";

}
