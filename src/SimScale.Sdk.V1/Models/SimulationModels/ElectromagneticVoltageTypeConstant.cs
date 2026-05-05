using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticVoltageTypeConstant : OneOf_VoltageExcitationVoltageType
{
    /// <summary>Schema name: ElectromagneticVoltageTypeConstant</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLTAGE_TYPE_CONSTANT";

    [JsonPropertyName("value")]
    public Dimensional_ElectricPotential? Value { get; set; }

}
