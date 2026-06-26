using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrequencyList : OneOf_SolidSimulationControlExcitationFrequencies, OneOf_HarmonicResponseControlExcitationFrequencies
{
    /// <summary>Schema name: FrequencyList</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LIST_V20";

    [JsonPropertyName("startFrequency")]
    public Dimensional_Frequency? StartFrequency { get; set; }

    [JsonPropertyName("endFrequency")]
    public Dimensional_Frequency? EndFrequency { get; set; }

    [JsonPropertyName("frequencyStepping")]
    public RestrictedDimensionalFunction_Frequency? FrequencyStepping { get; set; }

}
