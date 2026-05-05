using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectricCurrentDensityFieldSelection : OneOf_ElectromagneticResultControlProbePointFieldSelection
{
    /// <summary>Schema name: ElectricCurrentDensityFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTRIC_CURRENT_DENSITY";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
