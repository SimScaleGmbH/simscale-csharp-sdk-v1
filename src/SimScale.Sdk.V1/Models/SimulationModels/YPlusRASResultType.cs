using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class YPlusRASResultType : OneOf_FieldCalculationsTurbulenceResultControlResultType
{
    /// <summary>Schema name: YPlusRASResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DIMENSIONLESS_WALL_DISTANCE_YPLUS";

}
