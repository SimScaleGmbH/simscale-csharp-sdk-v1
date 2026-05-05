using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicResponseControl
{
    [JsonPropertyName("excitationFrequencies")]
    public OneOf_HarmonicResponseControlExcitationFrequencies? ExcitationFrequencies { get; set; }

}
