using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SutherlandTransport : OneOf_FluidCompressibleMaterialTransport
{
    /// <summary>Schema name: SutherlandTransport</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUTHERLAND";

    [JsonPropertyName("referenceViscosity")]
    public Dimensional_DynamicViscosity? ReferenceViscosity { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

    [JsonPropertyName("ts")]
    public Dimensional_Temperature? Ts { get; set; }

    [JsonPropertyName("thermo")]
    public OneOf_SutherlandTransportThermo? Thermo { get; set; }

}
