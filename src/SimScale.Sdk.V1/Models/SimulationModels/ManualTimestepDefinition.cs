using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualTimestepDefinition : OneOf_SolidSimulationControlTimestepDefinition
{
    /// <summary>Schema name: ManualTimestepDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_V19";

    [JsonPropertyName("simulationInterval")]
    public Dimensional_Time? SimulationInterval { get; set; }

    [JsonPropertyName("timestepLength")]
    public RestrictedDimensionalFunction_Time? TimestepLength { get; set; }

}
