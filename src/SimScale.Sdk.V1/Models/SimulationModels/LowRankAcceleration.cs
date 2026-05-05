using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LowRankAcceleration : OneOf_AdvancedMUMPSSettingsMumpsAcceleration
{
    /// <summary>Schema name: LowRankAcceleration</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOW_RANK";

    [JsonPropertyName("lowRankThreshold")]
    public double? LowRankThreshold { get; set; }

}
