using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticCurrentTypeSinusoidal : OneOf_CurrentExcitationCurrentType
{
    /// <summary>Schema name: ElectromagneticCurrentTypeSinusoidal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_TYPE_SINUSOIDAL";

    [JsonPropertyName("frequency")]
    public Dimensional_Frequency? Frequency { get; set; }

    [JsonPropertyName("amplitude")]
    public Dimensional_ElectricCurrent? Amplitude { get; set; }

    [JsonPropertyName("offset")]
    public Dimensional_ElectricCurrent? Offset { get; set; }

    [JsonPropertyName("timeOffset")]
    public Dimensional_Time? TimeOffset { get; set; }

}
