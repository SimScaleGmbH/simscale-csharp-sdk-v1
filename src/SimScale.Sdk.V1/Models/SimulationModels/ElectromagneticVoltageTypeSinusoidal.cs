using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticVoltageTypeSinusoidal : OneOf_VoltageExcitationVoltageType
{
    /// <summary>Schema name: ElectromagneticVoltageTypeSinusoidal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLTAGE_TYPE_SINUSOIDAL";

    [JsonPropertyName("frequency")]
    public Dimensional_Frequency? Frequency { get; set; }

    [JsonPropertyName("amplitude")]
    public Dimensional_ElectricPotential? Amplitude { get; set; }

    [JsonPropertyName("offset")]
    public Dimensional_ElectricPotential? Offset { get; set; }

    [JsonPropertyName("timeOffset")]
    public Dimensional_Time? TimeOffset { get; set; }

}
