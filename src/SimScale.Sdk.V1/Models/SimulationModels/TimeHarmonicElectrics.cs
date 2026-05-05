using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeHarmonicElectrics : OneOf_ElectromagneticAnalysisModel
{
    /// <summary>Schema name: TimeHarmonicElectrics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_HARMONIC_ELECTRICS";

    [JsonPropertyName("frequency")]
    public Dimensional_Frequency? Frequency { get; set; }

}
