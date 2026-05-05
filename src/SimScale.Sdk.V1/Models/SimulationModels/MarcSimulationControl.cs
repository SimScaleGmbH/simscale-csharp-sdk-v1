using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcSimulationControl
{
    [JsonPropertyName("timestepDefinition")]
    public OneOf_MarcSimulationControlTimestepDefinition? TimestepDefinition { get; set; }

    [JsonPropertyName("outputWritingContainer")]
    public MarcOutputWritingContainer? OutputWritingContainer { get; set; }

    /// <summary>Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will sav...</summary>
    [JsonPropertyName("numProcessors")]
    public long? NumProcessors { get; set; }

    [JsonPropertyName("manuallyAssignParallelization")]
    public bool? ManuallyAssignParallelization { get; set; }

    [JsonPropertyName("nprocds")]
    public int? Nprocds { get; set; }

    [JsonPropertyName("nte")]
    public int? Nte { get; set; }

    [JsonPropertyName("nts")]
    public int? Nts { get; set; }

    [JsonPropertyName("nsolver")]
    public int? Nsolver { get; set; }

    [JsonPropertyName("maxRunTime")]
    public Dimensional_Time? MaxRunTime { get; set; }

    /// <summary>Determines whether simulation results are updated in the post-processor in real-time while the solver is still runnin...</summary>
    [JsonPropertyName("livePostprocessing")]
    public bool? LivePostprocessing { get; set; }

}
