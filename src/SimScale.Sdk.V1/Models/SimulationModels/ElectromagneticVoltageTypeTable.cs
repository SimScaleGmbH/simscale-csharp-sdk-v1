using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticVoltageTypeTable : OneOf_VoltageExcitationVoltageType
{
    /// <summary>Schema name: ElectromagneticVoltageTypeTable</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLTAGE_TYPE_TABLE";

    [JsonPropertyName("values")]
    public DimensionalFunction_ElectricPotential? Values { get; set; }

}
