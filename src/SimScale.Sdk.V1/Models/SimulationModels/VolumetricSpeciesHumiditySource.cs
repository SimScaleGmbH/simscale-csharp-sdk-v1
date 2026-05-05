using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Humidity sources can be used to simulate humidity generation from a volume, knowing the mass of species entering the fluid domain per second.</summary>
public class VolumetricSpeciesHumiditySource : OneOf_AdvancedConceptsHumiditySources
{
    /// <summary>Humidity sources can be used to simulate humidity generation from a volume, knowing the mass of species entering the...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUMETRIC_SPECIES_MASS_FLOW_RATE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("waterVaporMassRate")]
    public Dimensional_AbsoluteHumidityRate? WaterVaporMassRate { get; set; }

    [JsonPropertyName("dryAirMassRate")]
    public Dimensional_AbsoluteHumidityRate? DryAirMassRate { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
