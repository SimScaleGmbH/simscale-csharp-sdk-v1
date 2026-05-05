using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StatisticalAveragingResultControlV2
{
    /// <summary>Schema name: StatisticalAveragingResultControlV2</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATISTICAL_AVERAGING_V2";

    /// <summary>It defines the point in simulation where the result output data extraction starts. For instance, Fraction from end of...</summary>
    [JsonPropertyName("fractionFromEnd")]
    public double? FractionFromEnd { get; set; }

    [JsonPropertyName("samplingInterval")]
    public OneOf_StatisticalAveragingResultControlV2SamplingInterval? SamplingInterval { get; set; }

    /// <summary>When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported</summary>
    [JsonPropertyName("exportFluid")]
    public bool? ExportFluid { get; set; }

    /// <summary>When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported</summary>
    [JsonPropertyName("exportSurface")]
    public bool? ExportSurface { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
