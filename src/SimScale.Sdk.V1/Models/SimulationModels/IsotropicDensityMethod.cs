using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicDensityMethod
{
    /// <summary>Schema name: IsotropicDensityMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_DENSITY_METHOD";

    [JsonPropertyName("density")]
    public DimensionalFunction_Density? Density { get; set; }

}
