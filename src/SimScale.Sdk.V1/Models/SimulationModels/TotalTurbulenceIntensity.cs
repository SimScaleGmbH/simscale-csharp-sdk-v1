using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalTurbulenceIntensity
{
    /// <summary>Schema name: TotalTurbulenceIntensity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_TURBULENCE_INTENSITY";

}
