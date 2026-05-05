using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidSimulationControl
{
    [JsonPropertyName("timestepDefinition")]
    public OneOf_SolidSimulationControlTimestepDefinition? TimestepDefinition { get; set; }

    [JsonPropertyName("pseudoTimeStepping")]
    public OneOf_SolidSimulationControlPseudoTimeStepping? PseudoTimeStepping { get; set; }

    /// <summary>Loads and enforced motions will be ramped linearly over the simulation interval to aid solution convergence. Automati...</summary>
    [JsonPropertyName("autoLoadRamping")]
    public bool? AutoLoadRamping { get; set; }

    [JsonPropertyName("writeControlDefinition")]
    public OneOf_SolidSimulationControlWriteControlDefinition? WriteControlDefinition { get; set; }

    [JsonPropertyName("excitationFrequencies")]
    public OneOf_SolidSimulationControlExcitationFrequencies? ExcitationFrequencies { get; set; }

    [JsonPropertyName("eigenfrequencyScope")]
    public OneOf_SolidSimulationControlEigenfrequencyScope? EigenfrequencyScope { get; set; }

    [JsonPropertyName("modalBase")]
    public ModalBaseControl? ModalBase { get; set; }

    [JsonPropertyName("harmonicResponse")]
    public HarmonicResponseControl? HarmonicResponse { get; set; }

    [JsonPropertyName("processors")]
    public ComputingCore? Processors { get; set; }

    [JsonPropertyName("maxRunTime")]
    public Dimensional_Time? MaxRunTime { get; set; }

}
