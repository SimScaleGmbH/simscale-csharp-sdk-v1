using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LocalEulerTimeDifferentiationScheme : OneOf_TimeDifferentiationSchemesForDefault
{
    /// <summary>Schema name: LocalEulerTimeDifferentiationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_EULER";

}
