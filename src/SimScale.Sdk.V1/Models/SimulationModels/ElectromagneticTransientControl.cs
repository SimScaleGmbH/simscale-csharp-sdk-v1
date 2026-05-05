using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticTransientControl
{
    [JsonPropertyName("endTime")]
    public Dimensional_Time? EndTime { get; set; }

    [JsonPropertyName("timeIncrement")]
    public Dimensional_Time? TimeIncrement { get; set; }

}
