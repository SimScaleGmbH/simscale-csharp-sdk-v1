using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LitzWireCoil : OneOf_CoilCoilType
{
    /// <summary>Schema name: LitzWireCoil</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LITZ_WIRE_COIL";

    [JsonPropertyName("strandCrossSectionType")]
    public OneOf_LitzWireCoilStrandCrossSectionType? StrandCrossSectionType { get; set; }

    /// <summary>The Number of Turns option indicates the number of times the wire is wound around the coil's core to form loops. Each...</summary>
    [JsonPropertyName("numberOfTurns")]
    public int? NumberOfTurns { get; set; }

    [JsonPropertyName("numberOfStrandsPerTurn")]
    public int? NumberOfStrandsPerTurn { get; set; }

}
