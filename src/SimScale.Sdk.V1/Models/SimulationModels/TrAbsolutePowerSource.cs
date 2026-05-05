using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TrAbsolutePowerSource : OneOf_AdvancedConceptsPowerSources
{
    /// <summary>Schema name: TrAbsolutePowerSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TR_ABSOLUTE_POWER_SOURCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatFlux")]
    public DimensionalFunction_Power? HeatFlux { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
