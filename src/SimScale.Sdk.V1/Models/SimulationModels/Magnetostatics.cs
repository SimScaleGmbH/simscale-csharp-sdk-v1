using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Magnetostatics : OneOf_ElectromagneticAnalysisModel
{
    /// <summary>Schema name: Magnetostatics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MAGNETOSTATICS";

    /// <summary>Coupling with thermal solves for the temperature by considering electromagnetic losses such as Ohmic, hysteric or dis...</summary>
    [JsonPropertyName("thermal")]
    public bool? Thermal { get; set; }

}
