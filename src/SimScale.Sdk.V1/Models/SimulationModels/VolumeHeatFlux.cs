using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify the rate of heat transfer per unit volume within a body. Used for internal heat generation sources.</summary>
public class VolumeHeatFlux : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Specify the rate of heat transfer per unit volume within a body. Used for internal heat generation sources. Schema na...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUME_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatFluxValue")]
    public DimensionalFunction_VolumetricPower? HeatFluxValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
