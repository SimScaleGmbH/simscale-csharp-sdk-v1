using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class KurganovFluxScheme : OneOf_FluxSchemesForDefault
{
    /// <summary>Schema name: KurganovFluxScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "KURGANOV";

}
