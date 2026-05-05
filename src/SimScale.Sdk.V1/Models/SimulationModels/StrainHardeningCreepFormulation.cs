using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainHardeningCreepFormulation : OneOf_LinearElasticMaterialBehaviorCreepFormulation
{
    /// <summary>Schema name: StrainHardeningCreepFormulation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN_HARDENING";

    [JsonPropertyName("a")]
    public Dimensional_StrainRate? A { get; set; }

    /// <summary>Define the parameter n of the Strain Hardening creep formulation: &amp;epsilon;&amp;#775; = A*&amp;sigma;n*&amp;epsil...</summary>
    [JsonPropertyName("n")]
    public double? N { get; set; }

    /// <summary>Define the parameter m of the Strain Hardening creep formulation: &amp;epsilon;&amp;#775; = A*&amp;sigma;n*&amp;epsil...</summary>
    [JsonPropertyName("m")]
    public double? M { get; set; }

}
