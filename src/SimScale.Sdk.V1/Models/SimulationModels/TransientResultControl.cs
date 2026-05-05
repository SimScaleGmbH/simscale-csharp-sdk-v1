using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TransientResultControl
{
    /// <summary>Schema name: TransientResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRANSIENT";

    [JsonPropertyName("writeControl")]
    public OneOf_TransientResultControlWriteControl? WriteControl { get; set; }

    /// <summary>It defines the point in simulation where the result output data extraction starts. For instance, Fraction from end of...</summary>
    [JsonPropertyName("fractionFromEnd")]
    public double? FractionFromEnd { get; set; }

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
