using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsMeanAgeOfFluidResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsMeanAgeOfFluidResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AGE_OF_FLUID";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public MeanAgeOfFluidResultType? ResultType { get; set; }

    /// <summary>Enable or disable the diffusion term in the age of fluid equation. The exclusion of the diffusion term can be valid f...</summary>
    [JsonPropertyName("ageOfFluidDiffusion")]
    public bool? AgeOfFluidDiffusion { get; set; }

    /// <summary>The turbulent Schmidt number characteristic of the flow. For HVAC applications it is recommended to maintain the defa...</summary>
    [JsonPropertyName("turbulentSchmidtNumber")]
    public double? TurbulentSchmidtNumber { get; set; }

    [JsonPropertyName("diffusionCoefficient")]
    public Dimensional_KinematicViscosity? DiffusionCoefficient { get; set; }

}
