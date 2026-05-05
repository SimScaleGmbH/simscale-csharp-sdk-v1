using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalUnelasticStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalUnelasticStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "UNELASTIC";

}
