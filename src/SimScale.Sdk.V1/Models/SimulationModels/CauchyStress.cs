using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CauchyStress : OneOf_MarcStressResultControlItemStressType
{
    /// <summary>Schema name: CauchyStress</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CAUCHY";

}
