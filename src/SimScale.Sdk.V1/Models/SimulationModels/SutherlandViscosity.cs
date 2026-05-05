using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SutherlandViscosity : OneOf_FluidCompressibleMaterialViscosityModel
{
    /// <summary>Schema name: SutherlandViscosity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUTHERLAND_VISCOSITY";

    [JsonPropertyName("referenceViscosity")]
    public Dimensional_DynamicViscosity? ReferenceViscosity { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

    [JsonPropertyName("ts")]
    public Dimensional_Temperature? Ts { get; set; }

}
