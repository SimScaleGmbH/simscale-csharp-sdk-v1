using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrictionAugmentedLagrangeCoef : OneOf_FrictionContactFrictionCoefficient
{
    /// <summary>Schema name: FrictionAugmentedLagrangeCoef</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_AUGMENTATION_COEF";

    [JsonPropertyName("frictionAugmentationCoefficient")]
    public Dimensional_FrictionAugmentation? FrictionAugmentationCoefficient { get; set; }

    [JsonPropertyName("coulombCoefficient")]
    public double? CoulombCoefficient { get; set; }

}
