using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrandtlLesDelta : OneOf_FluidModelDeltaCoefficient
{
    /// <summary>Schema name: PrandtlLesDelta</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRANDTL";

    [JsonPropertyName("deltaCoefficient")]
    public OneOf_PrandtlLesDeltaDeltaCoefficient? DeltaCoefficient { get; set; }

    [JsonPropertyName("deltaReductionCoefficient")]
    public double? DeltaReductionCoefficient { get; set; }

}
