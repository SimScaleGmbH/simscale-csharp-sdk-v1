using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ReynoldsStressResultType : OneOf_FieldCalculationsTurbulenceResultControlResultType
{
    /// <summary>Schema name: ReynoldsStressResultType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REYNOLDS_STRESS_TENSOR";

}
