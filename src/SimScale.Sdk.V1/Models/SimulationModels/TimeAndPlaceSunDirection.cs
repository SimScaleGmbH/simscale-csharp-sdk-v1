using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeAndPlaceSunDirection : OneOf_SolarCalculatorSunDirection
{
    /// <summary>Schema name: TimeAndPlaceSunDirection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_AND_PLACE";

    [JsonPropertyName("northAngle")]
    public Dimensional_Angle? NorthAngle { get; set; }

    [JsonPropertyName("geographicalLocation")]
    public GeographicalLocation? GeographicalLocation { get; set; }

    [JsonPropertyName("localDateTime")]
    public string? LocalDateTime { get; set; }

}
