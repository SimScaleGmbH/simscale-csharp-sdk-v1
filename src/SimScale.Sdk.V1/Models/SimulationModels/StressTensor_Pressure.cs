using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StressTensor_Pressure
{
    [JsonPropertyName("sigmaXX")]
    public OneOf_StressTensor_PressureSigmaXX? SigmaXX { get; set; }

    [JsonPropertyName("sigmaYY")]
    public OneOf_StressTensor_PressureSigmaYY? SigmaYY { get; set; }

    [JsonPropertyName("sigmaZZ")]
    public OneOf_StressTensor_PressureSigmaZZ? SigmaZZ { get; set; }

    [JsonPropertyName("sigmaYZ")]
    public OneOf_StressTensor_PressureSigmaYZ? SigmaYZ { get; set; }

    [JsonPropertyName("sigmaXZ")]
    public OneOf_StressTensor_PressureSigmaXZ? SigmaXZ { get; set; }

    [JsonPropertyName("sigmaXY")]
    public OneOf_StressTensor_PressureSigmaXY? SigmaXY { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
