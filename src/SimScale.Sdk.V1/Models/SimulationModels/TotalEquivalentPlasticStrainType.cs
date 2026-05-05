using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalEquivalentPlasticStrainType : OneOf_StrainFieldSelectionStrainType
{
    /// <summary>Schema name: TotalEquivalentPlasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_EQUI_PLASTIC";

}
