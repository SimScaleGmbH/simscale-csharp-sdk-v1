using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticCircuit
{
    /// <summary>Schema name: ElectromagneticCircuit</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CIRCUIT";

    /// <summary>The file definition for the EMWORKS Circuit Netlist specification</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

}
