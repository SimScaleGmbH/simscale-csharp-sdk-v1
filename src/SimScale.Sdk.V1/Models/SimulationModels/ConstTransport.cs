using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConstTransport : OneOf_FluidCompressibleMaterialTransport
{
    /// <summary>Schema name: ConstTransport</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONST";

    [JsonPropertyName("dynamicViscosity")]
    public Dimensional_DynamicViscosity? DynamicViscosity { get; set; }

    [JsonPropertyName("dynamicViscosityFunction")]
    public DimensionalFunction_DynamicViscosity? DynamicViscosityFunction { get; set; }

    /// <summary>Prandtl number (Pr) is the ratio of momentum transport to thermal tranport. Fluids with low Pr are free flowing and g...</summary>
    [JsonPropertyName("prandtlNumber")]
    public double? PrandtlNumber { get; set; }

    /// <summary>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</summary>
    [JsonPropertyName("turbulentPrandtlNumber")]
    public double? TurbulentPrandtlNumber { get; set; }

    [JsonPropertyName("thermo")]
    public OneOf_ConstTransportThermo? Thermo { get; set; }

}
