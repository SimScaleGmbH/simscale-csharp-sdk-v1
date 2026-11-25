using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CircuitExcitation : OneOf_CoilExcitation
{
    /// <summary>Schema name: CircuitExcitation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CIRCUIT_EXCITATION";

}
