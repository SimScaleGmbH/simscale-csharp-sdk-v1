using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrequencyRange : OneOf_ModalBaseControlEigenfrequencyScope, OneOf_SolidSimulationControlEigenfrequencyScope
{
    /// <summary>Schema name: FrequencyRange</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RANGE";

    [JsonPropertyName("startFrequency")]
    public Dimensional_Frequency? StartFrequency { get; set; }

    [JsonPropertyName("endFrequency")]
    public Dimensional_Frequency? EndFrequency { get; set; }

    [JsonPropertyName("numberOfSubBands")]
    public int? NumberOfSubBands { get; set; }

    [JsonPropertyName("parallelizationLevel")]
    public string? ParallelizationLevel { get; set; }

}
