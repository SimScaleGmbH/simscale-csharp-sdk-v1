using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StandingFractionBodySurface : OneOf_MrtSolarParametersFractionBodySurface
{
    /// <summary>Schema name: StandingFractionBodySurface</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STANDING_FRACTION_BODY_SURFACE";

}
