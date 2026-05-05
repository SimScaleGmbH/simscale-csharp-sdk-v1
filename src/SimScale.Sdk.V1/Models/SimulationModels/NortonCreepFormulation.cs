using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NortonCreepFormulation : OneOf_LinearElasticMaterialBehaviorCreepFormulation
{
    /// <summary>Schema name: NortonCreepFormulation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORTON";

    [JsonPropertyName("a")]
    public Dimensional_StrainRate? A { get; set; }

    /// <summary>Define the parameter n of the Norton creep formulation: &amp;epsilon;&amp;#775; = A*&amp;sigma;n</summary>
    [JsonPropertyName("n")]
    public double? N { get; set; }

}
