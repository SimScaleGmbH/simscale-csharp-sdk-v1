using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify a fixed temperature at a volume or boundary. Used for parts maintained at a known temperature.</summary>
public class FixedTemperature : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Specify a fixed temperature at a volume or boundary. Used for parts maintained at a known temperature. Schema name: F...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_TEMPERATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("temperature")]
    public DimensionalFunction_Temperature? Temperature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
