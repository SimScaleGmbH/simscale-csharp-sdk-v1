using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsAdjointSensitivitiesResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsAdjointSensitivitiesResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADJOINT_SENSITIVITIES";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("computeSensitivitiesTo")]
    public string? ComputeSensitivitiesTo { get; set; }

    [JsonPropertyName("optimizationForceDirection")]
    public DecimalVector? OptimizationForceDirection { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
