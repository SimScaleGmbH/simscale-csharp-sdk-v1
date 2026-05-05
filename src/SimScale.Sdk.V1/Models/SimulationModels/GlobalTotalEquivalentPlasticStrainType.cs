using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalTotalEquivalentPlasticStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalTotalEquivalentPlasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_EQUI_PLASTIC";

}
