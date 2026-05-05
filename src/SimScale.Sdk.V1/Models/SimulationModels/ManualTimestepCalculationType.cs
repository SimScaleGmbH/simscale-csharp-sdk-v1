using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):Manual: Here the user defines fixed time step subdivision and augmentation settings.Newton Iterations Target: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.Field Change Target: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.Mixed: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.</summary>
public class ManualTimestepCalculationType : OneOf_NonMonotomousResidualRetimingEventTimestepCalculationType, OneOf_ErrorRetimingEventTimestepCalculationType
{
    /// <summary>Select how the time increments should be computed in case of an adaptation event. Currently four types are available...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    /// <summary>Define the percentage of additional Newton Iterations that should be allowed to be used if convergence is not reached...</summary>
    [JsonPropertyName("additionalNewtonIterations")]
    public double? AdditionalNewtonIterations { get; set; }

    [JsonPropertyName("fixedSubdivision")]
    public FixedSubdivision? FixedSubdivision { get; set; }

    [JsonPropertyName("fixedAugmentation")]
    public FixedAugmentation? FixedAugmentation { get; set; }

}
