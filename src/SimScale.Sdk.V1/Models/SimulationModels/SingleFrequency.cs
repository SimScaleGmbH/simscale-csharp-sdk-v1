using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SingleFrequency : OneOf_HarmonicResponseControlExcitationFrequencies, OneOf_SolidSimulationControlExcitationFrequencies
{
    /// <summary>Schema name: SingleFrequency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SINGLE";

    [JsonPropertyName("frequency")]
    public Dimensional_Frequency? Frequency { get; set; }

}
