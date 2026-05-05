using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EulerTimeDifferentiationScheme : OneOf_TimeDifferentiationSchemesForDefault
{
    /// <summary>Schema name: EulerTimeDifferentiationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EULER";

}
