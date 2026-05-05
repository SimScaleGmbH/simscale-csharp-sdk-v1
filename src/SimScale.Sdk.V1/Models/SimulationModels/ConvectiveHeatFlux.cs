using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Represents heat transfer between a surface and a fluid.</summary>
public class ConvectiveHeatFlux : OneOf_ElectromagneticAnalysisBoundaryConditions
{
    /// <summary>Represents heat transfer between a surface and a fluid. Schema name: ConvectiveHeatFlux</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTIVE_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatTransferCoefficient")]
    public DimensionalFunction_ThermalTransmittance? HeatTransferCoefficient { get; set; }

    [JsonPropertyName("ambientTemperature")]
    public DimensionalFunction_Temperature? AmbientTemperature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
