using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PerfectThermalContact : OneOf_MarcBondedContactConnectionThermalContact
{
    /// <summary>Schema name: PerfectThermalContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERFECT";

}
