using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ClusterAroundModes : OneOf_HarmonicResponseControlExcitationFrequencies
{
    /// <summary>Schema name: ClusterAroundModes</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CLUSTER_AROUND_MODES";

    [JsonPropertyName("startFrequency")]
    public Dimensional_Frequency? StartFrequency { get; set; }

    [JsonPropertyName("endFrequency")]
    public Dimensional_Frequency? EndFrequency { get; set; }

    /// <summary>Specify the number of excitation frequencies to be clustered around each eigenfrequency. The eigenfrequency itself wi...</summary>
    [JsonPropertyName("frequenciesPerMode")]
    public int? FrequenciesPerMode { get; set; }

    /// <summary>Define the total bandwidth around each eigenfrequency, as a percentage of each individual eigenfrequency, within whic...</summary>
    [JsonPropertyName("percentageSpread")]
    public double? PercentageSpread { get; set; }

}
