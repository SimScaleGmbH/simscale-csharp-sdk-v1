using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TravelDistance : OneOf_MotionAxisTravelLimit
{
    /// <summary>Schema name: TravelDistance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRAVEL_DISTANCE";

    [JsonPropertyName("forwardTravel")]
    public Dimensional_Length? ForwardTravel { get; set; }

    [JsonPropertyName("backwardTravel")]
    public Dimensional_Length? BackwardTravel { get; set; }

}
