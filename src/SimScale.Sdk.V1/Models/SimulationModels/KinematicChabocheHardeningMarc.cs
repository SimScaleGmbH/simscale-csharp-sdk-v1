using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class KinematicChabocheHardeningMarc : OneOf_VoceChabocheModelMarcHardeningRule
{
    /// <summary>Schema name: KinematicChabocheHardeningMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "KINEMATIC";

    [JsonPropertyName("backstressTerms")]
    public OneOf_KinematicChabocheHardeningMarcBackstressTerms? BackstressTerms { get; set; }

}
