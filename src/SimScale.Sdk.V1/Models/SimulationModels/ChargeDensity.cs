using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Assign a specific charge density to a body.</summary>
public class ChargeDensity : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Assign a specific charge density to a body. Schema name: ChargeDensity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CHARGE_DENSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("chargeDensity")]
    public Dimensional_ChargeDensity? ChargeDensityValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
