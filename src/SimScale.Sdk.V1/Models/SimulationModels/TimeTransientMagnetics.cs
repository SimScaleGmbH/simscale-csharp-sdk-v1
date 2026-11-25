using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeTransientMagnetics : OneOf_ElectromagneticAnalysisModel
{
    /// <summary>Schema name: TimeTransientMagnetics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_TRANSIENT_MAGNETICS";

    /// <summary>Coupling with thermal solves for the temperature by considering electromagnetic losses such as Ohmic, hysteric or dis...</summary>
    [JsonPropertyName("thermal")]
    public bool? Thermal { get; set; }

    /// <summary>Once enabled, all excitation coils are driven through a user specified electric circuit.</summary>
    [JsonPropertyName("circuit")]
    public bool? Circuit { get; set; }

    /// <summary>Once enabled, bodies can be set in motion. The motion can be prescribed, or computed from the forces the body experie...</summary>
    [JsonPropertyName("motion")]
    public bool? Motion { get; set; }

}
