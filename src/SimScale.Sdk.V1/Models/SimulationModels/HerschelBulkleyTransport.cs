using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HerschelBulkleyTransport : OneOf_FluidCompressibleMaterialTransport
{
    /// <summary>Schema name: HerschelBulkleyTransport</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HERSCHEL_BULKLEY";

    [JsonPropertyName("viscosityModel")]
    public StandardHerschelBulkleyViscosityModel? ViscosityModel { get; set; }

    /// <summary>Prandtl number (Pr) is the ratio of momentum transport to thermal tranport. Fluids with low Pr are free flowing and g...</summary>
    [JsonPropertyName("prandtlNumber")]
    public double? PrandtlNumber { get; set; }

    /// <summary>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</summary>
    [JsonPropertyName("turbulentPrandtlNumber")]
    public double? TurbulentPrandtlNumber { get; set; }

    [JsonPropertyName("thermo")]
    public HConstThermo? Thermo { get; set; }

}
