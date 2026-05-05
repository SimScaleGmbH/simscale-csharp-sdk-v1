using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecificResistanceInterfaceThermal : OneOf_ContactResistanceLayerInterfaceThermal
{
    /// <summary>Schema name: SpecificResistanceInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIC_RESISTANCE";

    [JsonPropertyName("contactResistance")]
    public Dimensional_SpecificContactResistance? ContactResistance { get; set; }

    [JsonPropertyName("electricResistance")]
    public Dimensional_SpecificElectricResistance? ElectricResistance { get; set; }

}
