using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectricDisplacementFieldFieldSelection : OneOf_ElectromagneticResultControlProbePointFieldSelection
{
    /// <summary>Schema name: ElectricDisplacementFieldFieldSelection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTRIC_DISPLACEMENT_FIELD";

}
