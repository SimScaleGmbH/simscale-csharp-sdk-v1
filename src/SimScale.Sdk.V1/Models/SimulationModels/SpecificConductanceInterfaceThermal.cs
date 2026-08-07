using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecificConductanceInterfaceThermal : OneOf_ContactConductanceLayerInterfaceThermal, OneOf_RegionInterfaceInterfaceThermal
{
    /// <summary>Schema name: SpecificConductanceInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIC_CONDUCTANCE";

    [JsonPropertyName("contactConductance")]
    public Dimensional_ThermalTransmittance? ContactConductance { get; set; }

    [JsonPropertyName("electricConductance")]
    public Dimensional_SpecificElectricConductance? ElectricConductance { get; set; }

}
