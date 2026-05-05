using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SingleStepPseudoTimeStepping : OneOf_SolidSimulationControlPseudoTimeStepping
{
    /// <summary>Schema name: SingleStepPseudoTimeStepping</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SINGLE_STEP";

    [JsonPropertyName("staticTimesteps")]
    public Dimensional_Time? StaticTimesteps { get; set; }

}
