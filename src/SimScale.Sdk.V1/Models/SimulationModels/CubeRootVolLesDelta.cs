using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CubeRootVolLesDelta : OneOf_PrandtlLesDeltaDeltaCoefficient, OneOf_FluidModelDeltaCoefficient
{
    /// <summary>Schema name: CubeRootVolLesDelta</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUBE_ROOT_VOL";

    [JsonPropertyName("deltaCoefficient")]
    public double? DeltaCoefficient { get; set; }

}
