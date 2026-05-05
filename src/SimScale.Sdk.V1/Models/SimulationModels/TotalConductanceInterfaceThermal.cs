using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalConductanceInterfaceThermal : OneOf_ContactConductanceLayerInterfaceThermal
{
    /// <summary>Schema name: TotalConductanceInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_CONDUCTANCE";

    [JsonPropertyName("contactConductance")]
    public Dimensional_TotalThermalTransmittance? ContactConductance { get; set; }

    [JsonPropertyName("electricConductance")]
    public Dimensional_ElectricConductance? ElectricConductance { get; set; }

}
