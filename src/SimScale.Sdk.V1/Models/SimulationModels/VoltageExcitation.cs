using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VoltageExcitation : OneOf_CoilExcitation
{
    /// <summary>Schema name: VoltageExcitation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLTAGE_EXCITATION";

    [JsonPropertyName("voltageType")]
    public OneOf_VoltageExcitationVoltageType? VoltageType { get; set; }

    [JsonPropertyName("voltageRMS")]
    public Dimensional_ElectricPotential? VoltageRMS { get; set; }

    [JsonPropertyName("voltagePhase")]
    public Dimensional_Angle? VoltagePhase { get; set; }

    [JsonPropertyName("additionalResistance")]
    public Dimensional_ElectricResistance? AdditionalResistance { get; set; }

}
