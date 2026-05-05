using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrandedCoil : OneOf_CoilCoilType
{
    /// <summary>Schema name: StrandedCoil</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRANDED_COIL";

    /// <summary>The Number of Turns option indicates the number of times the wire is wound around the coil's core to form loops. Each...</summary>
    [JsonPropertyName("numberOfTurns")]
    public int? NumberOfTurns { get; set; }

    [JsonPropertyName("wireDiameter")]
    public Dimensional_Length? WireDiameter { get; set; }

}
