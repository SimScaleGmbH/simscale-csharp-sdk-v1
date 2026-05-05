using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SittingFractionBodySurface : OneOf_MrtSolarParametersFractionBodySurface
{
    /// <summary>Schema name: SittingFractionBodySurface</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SITTING_FRACTION_BODY_SURFACE";

}
