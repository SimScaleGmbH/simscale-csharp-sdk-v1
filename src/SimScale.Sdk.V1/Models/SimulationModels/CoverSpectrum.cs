using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CoverSpectrum : OneOf_HarmonicResponseControlExcitationFrequencies
{
    /// <summary>Schema name: CoverSpectrum</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COVER_SPECTRUM";

    [JsonPropertyName("startFrequency")]
    public Dimensional_Frequency? StartFrequency { get; set; }

    [JsonPropertyName("endFrequency")]
    public Dimensional_Frequency? EndFrequency { get; set; }

    /// <summary>Specify the number of excitation frequencies to be spread over each modal peak and neighbouring valleys. The eigenfre...</summary>
    [JsonPropertyName("frequenciesPerMode")]
    public int? FrequenciesPerMode { get; set; }

    /// <summary>Ratio of the adjacent distances between excitation frequencies. It controls the distribution of the frequencies, with...</summary>
    [JsonPropertyName("growthRatio")]
    public double? GrowthRatio { get; set; }

}
