using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalTotalNonlinearStrainType : OneOf_StrainResultControlItemStrainType
{
    /// <summary>Schema name: GlobalTotalNonlinearStrainType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_NONLINEAR";

}
