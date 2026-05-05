using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomFractionBodySurface : OneOf_MrtSolarParametersFractionBodySurface
{
    /// <summary>Schema name: CustomFractionBodySurface</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_FRACTION_BODY_SURFACE";

    [JsonPropertyName("value")]
    public double? Value { get; set; }

}
