using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeHarmonicMagnetics : OneOf_ElectromagneticAnalysisModel
{
    /// <summary>Schema name: TimeHarmonicMagnetics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_HARMONIC_MAGNETICS";

    [JsonPropertyName("frequency")]
    public Dimensional_Frequency? Frequency { get; set; }

    /// <summary>Coupling with thermal solves for the temperature by considering electromagnetic losses such as Ohmic, hysteric or dis...</summary>
    [JsonPropertyName("thermal")]
    public bool? Thermal { get; set; }

}
