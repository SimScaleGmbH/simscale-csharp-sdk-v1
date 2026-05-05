using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SnapshotResultControl
{
    /// <summary>Schema name: SnapshotResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SNAPSHOT";

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
