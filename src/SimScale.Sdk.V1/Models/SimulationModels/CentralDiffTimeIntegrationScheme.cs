using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CentralDiffTimeIntegrationScheme : OneOf_ExplicitTimeIntegrationTypeScheme
{
    /// <summary>Schema name: CentralDiffTimeIntegrationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CENTRAL_DIFF";

}
