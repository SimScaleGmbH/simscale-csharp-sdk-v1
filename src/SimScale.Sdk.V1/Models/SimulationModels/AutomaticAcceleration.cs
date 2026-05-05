using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticAcceleration : OneOf_AdvancedMUMPSSettingsMumpsAcceleration
{
    /// <summary>Schema name: AutomaticAcceleration</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

}
