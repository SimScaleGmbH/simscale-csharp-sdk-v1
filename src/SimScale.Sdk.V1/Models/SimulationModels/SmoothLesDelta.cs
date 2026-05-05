using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SmoothLesDelta : OneOf_PrandtlLesDeltaDeltaCoefficient, OneOf_FluidModelDeltaCoefficient
{
    /// <summary>Schema name: SmoothLesDelta</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SMOOTH";

    [JsonPropertyName("deltaCoefficient")]
    public CubeRootVolLesDelta? DeltaCoefficient { get; set; }

    [JsonPropertyName("maxDeltaRatio")]
    public double? MaxDeltaRatio { get; set; }

}
