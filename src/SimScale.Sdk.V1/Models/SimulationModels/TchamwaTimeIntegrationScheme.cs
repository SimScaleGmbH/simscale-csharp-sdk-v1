using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TchamwaTimeIntegrationScheme : OneOf_ExplicitTimeIntegrationTypeScheme
{
    /// <summary>Schema name: TchamwaTimeIntegrationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TCHAMWA";

    /// <summary>The parameter &amp;phi; allows inducing numerical damping. For &amp;phi; = 1.0 there is no numerical damping whereas...</summary>
    [JsonPropertyName("phi")]
    public double? Phi { get; set; }

}
