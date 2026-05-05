using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidSimulationControl
{
    [JsonPropertyName("endTime")]
    public Dimensional_Time? EndTime { get; set; }

    [JsonPropertyName("adjointEndTime")]
    public Dimensional_Time? AdjointEndTime { get; set; }

    /// <summary>This represents the total number of iterations at which the simulation will terminate. No further iterations will be...</summary>
    [JsonPropertyName("numberOfIterations")]
    public int? NumberOfIterations { get; set; }

    [JsonPropertyName("deltaT")]
    public Dimensional_Time? DeltaT { get; set; }

    [JsonPropertyName("variableDeltaT")]
    public DimensionalFunction_Time? VariableDeltaT { get; set; }

    [JsonPropertyName("adjustableTimestep")]
    public OneOf_FluidSimulationControlAdjustableTimestep? AdjustableTimestep { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_FluidSimulationControlWriteControl? WriteControl { get; set; }

    /// <summary>Steady-state simulation: This represents the relative error residuals that once attained by the solver the simulation...</summary>
    [JsonPropertyName("relativeConvergenceCriteria")]
    public double? RelativeConvergenceCriteria { get; set; }

    /// <summary>Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will sav...</summary>
    [JsonPropertyName("numProcessors")]
    public int? NumProcessors { get; set; }

    [JsonPropertyName("maxRunTime")]
    public Dimensional_Time? MaxRunTime { get; set; }

    /// <summary>It affects the stability of the simulation. The default value of 0.1 is a good compromise between accuracy and comput...</summary>
    [JsonPropertyName("velocityScaling")]
    public double? VelocityScaling { get; set; }

    /// <summary>This setting activates the solution of a potential flow field. The potential flow is used as initial condition for th...</summary>
    [JsonPropertyName("potentialFoamInitialization")]
    public bool? PotentialFoamInitialization { get; set; }

    [JsonPropertyName("decomposeAlgorithm")]
    public OneOf_FluidSimulationControlDecomposeAlgorithm? DecomposeAlgorithm { get; set; }

}
