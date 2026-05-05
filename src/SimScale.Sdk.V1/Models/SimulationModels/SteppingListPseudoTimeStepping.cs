using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SteppingListPseudoTimeStepping : OneOf_SolidSimulationControlPseudoTimeStepping
{
    /// <summary>Schema name: SteppingListPseudoTimeStepping</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STEPPING_LIST_V18";

    [JsonPropertyName("simulationIntervals")]
    public Dimensional_Time? SimulationIntervals { get; set; }

    [JsonPropertyName("timestepLength")]
    public RestrictedDimensionalFunction_Time? TimestepLength { get; set; }

}
