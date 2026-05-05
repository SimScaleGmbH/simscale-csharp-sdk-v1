using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectricPotentialFieldSelection : OneOf_ElectromagneticResultControlProbePointFieldSelection
{
    /// <summary>Schema name: ElectricPotentialFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTRIC_POTENTIAL";

}
