using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticTurbulence : OneOf_NaturalConvectionInletOutletBCTurbulence, OneOf_FanBCTurbulence, OneOf_PressureInletBCTurbulence, OneOf_VelocityInletBCTurbulence
{
    /// <summary>Schema name: AutomaticTurbulence</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_TURBULENCE";

}
