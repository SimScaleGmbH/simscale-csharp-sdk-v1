using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HhtTimeIntegrationScheme : OneOf_ImplicitTimeIntegrationTypeScheme
{
    /// <summary>Schema name: HhtTimeIntegrationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HHT";

    /// <summary>The parameter &amp;alpha; is given by a negative value. The larger |&amp;alpha;| is, the more numerical damping is in...</summary>
    [JsonPropertyName("alpha")]
    public double? Alpha { get; set; }

    /// <summary>Choose the mode of the HHT method. Compared to the average acceleration scheme the induced numerical damping of the a...</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

}
