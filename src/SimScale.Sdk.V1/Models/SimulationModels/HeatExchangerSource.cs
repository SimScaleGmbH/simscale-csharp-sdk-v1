using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Power sources can be used to simulate heat generation from a volume. Three types are available:Absolute: Used when total power emitted by the assigned volume is known.Specific: Used when power density of the assigned volume is known.Heat exchanger: Used to model a heat exchanger on a fluid region. The heat input is computed from the total conductance (U [W/K]) and the difference between the fluid temperature (T) and the heat exchanger temperature (Tref). Q = U (T - Tref). Learn more.</summary>
public class HeatExchangerSource : OneOf_AdvancedConceptsPowerSources
{
    /// <summary>Power sources can be used to simulate heat generation from a volume. Three types are available:Absolute: Used when to...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_EXCHANGER_SOURCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatExchangerMode")]
    public OneOf_HeatExchangerSourceHeatExchangerMode? HeatExchangerMode { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
