using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AmbientTBC : OneOf_FanBCTemperature
{
    /// <summary>Schema name: AmbientTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AMBIENT_TEMPERATURE";

    [JsonPropertyName("ambientTemperature")]
    public Dimensional_Temperature? AmbientTemperature { get; set; }

}
