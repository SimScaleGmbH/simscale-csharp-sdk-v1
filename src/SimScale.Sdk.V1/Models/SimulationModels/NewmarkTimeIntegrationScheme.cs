using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewmarkTimeIntegrationScheme : OneOf_ImplicitTimeIntegrationTypeScheme
{
    /// <summary>Schema name: NewmarkTimeIntegrationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWMARK";

    /// <summary>The choice of the values for the parameters &amp;alpha; and &amp;beta; influences the stability, accuracy and numeric...</summary>
    [JsonPropertyName("beta")]
    public double? Beta { get; set; }

    /// <summary>The choice of the values for the parameters &amp;alpha; and &amp;beta; influences the stability, accuracy and numeric...</summary>
    [JsonPropertyName("gamma")]
    public double? Gamma { get; set; }

}
