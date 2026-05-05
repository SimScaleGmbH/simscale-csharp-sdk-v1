using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EigenModeVerification
{
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    [JsonPropertyName("precisionShift")]
    public double? PrecisionShift { get; set; }

}
