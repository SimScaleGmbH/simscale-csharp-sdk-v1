using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualTimeStepDefintion : OneOf_MarcSimulationControlTimestepDefinition
{
    /// <summary>Schema name: ManualTimeStepDefintion</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    [JsonPropertyName("endTime")]
    public Dimensional_Time? EndTime { get; set; }

    [JsonPropertyName("timeStepLength")]
    public DimensionalFunction_Time? TimeStepLength { get; set; }

    /// <summary>The maximum number of times to cut down the time step in each increment when convergence criteria are not met.</summary>
    [JsonPropertyName("cutbacks")]
    public int? Cutbacks { get; set; }

}
