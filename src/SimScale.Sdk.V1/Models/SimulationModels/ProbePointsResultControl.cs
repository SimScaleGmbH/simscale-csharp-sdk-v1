using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ProbePointsResultControl
{
    /// <summary>Schema name: ProbePointsResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PROBE_POINTS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_ProbePointsResultControlWriteControl? WriteControl { get; set; }

    /// <summary>It defines the point in simulation where the result output data extraction starts. For instance, Fraction from end of...</summary>
    [JsonPropertyName("fractionFromEnd")]
    public double? FractionFromEnd { get; set; }

    /// <summary>When this switch is activated, statistical data for the selected probe points will be exported:Minimum (MIN)Maximum (...</summary>
    [JsonPropertyName("exportStatistics")]
    public bool? ExportStatistics { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

    [JsonPropertyName("probeLocations")]
    public TableDefinedProbeLocations? ProbeLocations { get; set; }

}
