using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define a Distributed mass boundary condition in order to insert an additional mass on a specific face of the active model.</summary>
public class DistributedMassBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions
{
    /// <summary>Define a Distributed mass boundary condition in order to insert an additional mass on a specific face of the active m...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTRIBUTED_MASS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("massDefinition")]
    public OneOf_DistributedMassBCMassDefinition? MassDefinition { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
