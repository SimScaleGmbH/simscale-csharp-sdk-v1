using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticAdvancedConcepts
{
    [JsonPropertyName("motionAnalysis")]
    public List<OneOf_ElectromagneticAdvancedConceptsMotionAnalysis>? MotionAnalysis { get; set; }

    [JsonPropertyName("circuit")]
    public ElectromagneticCircuit? Circuit { get; set; }

}
