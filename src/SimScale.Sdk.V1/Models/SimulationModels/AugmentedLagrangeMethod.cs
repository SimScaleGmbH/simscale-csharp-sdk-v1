using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AugmentedLagrangeMethod : OneOf_FrictionlessContactContactSolutionMethod, OneOf_FrictionContactContactSolutionMethod
{
    /// <summary>Schema name: AugmentedLagrangeMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUGMENTED_LAGRANGE";

    [JsonPropertyName("augmentedLagrangeCoefficient")]
    public double? AugmentedLagrangeCoefficient { get; set; }

}
