using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalResistanceWallThermal : OneOf_DerivedHeatFluxWallThermal
{
    /// <summary>Schema name: TotalResistanceWallThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_RESISTANCE";

    [JsonPropertyName("contactResistance")]
    public Dimensional_ContactResistance? ContactResistance { get; set; }

}
