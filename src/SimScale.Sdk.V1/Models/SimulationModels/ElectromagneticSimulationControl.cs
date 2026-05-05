using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticSimulationControl
{
    [JsonPropertyName("transientMagneticsControl")]
    public ElectromagneticTransientControl? TransientMagneticsControl { get; set; }

    [JsonPropertyName("writeControl")]
    public TimeStepWriteControl? WriteControl { get; set; }

    /// <summary>Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will sav...</summary>
    [JsonPropertyName("numProcessors")]
    public long? NumProcessors { get; set; }

    [JsonPropertyName("maxRunTime")]
    public Dimensional_Time? MaxRunTime { get; set; }

    [JsonPropertyName("coreLossReferencePeriod")]
    public Dimensional_Time? CoreLossReferencePeriod { get; set; }

    /// <summary>Activate when the coil excitation is periodic to accelerate simulation. For more information, please refer to our doc...</summary>
    [JsonPropertyName("timePeriodicAcceleration")]
    public bool? TimePeriodicAcceleration { get; set; }

}
