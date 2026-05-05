using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalResistanceInterfaceThermal : OneOf_RegionInterfaceInterfaceThermal, OneOf_ContactResistanceLayerInterfaceThermal
{
    /// <summary>Schema name: TotalResistanceInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_RESISTANCE";

    [JsonPropertyName("contactResistance")]
    public Dimensional_ContactResistance? ContactResistance { get; set; }

    [JsonPropertyName("electricResistance")]
    public Dimensional_ElectricResistance? ElectricResistance { get; set; }

}
