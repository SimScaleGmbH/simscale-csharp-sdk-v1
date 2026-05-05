using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeHardeningCreepFormulation : OneOf_LinearElasticMaterialBehaviorCreepFormulation
{
    /// <summary>Schema name: TimeHardeningCreepFormulation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_HARDENING";

    [JsonPropertyName("a")]
    public Dimensional_StrainRate? A { get; set; }

    /// <summary>Define the parameter n of the Time Hardening creep formulation: &amp;epsilon;&amp;#775; = A*&amp;sigma;n*tm</summary>
    [JsonPropertyName("n")]
    public double? N { get; set; }

    /// <summary>Define the parameter m of the Time Hardening creep formulation: &amp;epsilon;&amp;#775; = A*&amp;sigma;n*tm</summary>
    [JsonPropertyName("m")]
    public double? M { get; set; }

}
