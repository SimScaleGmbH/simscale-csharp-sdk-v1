using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidInitialConditions
{
    [JsonPropertyName("displacement")]
    public DimensionalVectorFunctionInitialConditionWithDomains_Length? Displacement { get; set; }

    [JsonPropertyName("velocity")]
    public DimensionalVectorFunctionInitialConditionWithDomains_Speed? Velocity { get; set; }

    [JsonPropertyName("acceleration")]
    public DimensionalVectorFunctionInitialConditionWithDomains_Acceleration? Acceleration { get; set; }

    [JsonPropertyName("stress")]
    public StressInitialConditionDomains? Stress { get; set; }

    [JsonPropertyName("temperature")]
    public DimensionalFunctionInitialConditionDomains_Temperature? Temperature { get; set; }

}
