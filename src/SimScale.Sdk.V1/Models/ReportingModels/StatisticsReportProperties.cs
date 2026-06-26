using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Configuration for a statistics (bulk calculation) report. Computes scalar field statistics (minimum, maximum, average, integral, and area/volume-weighted equivalents) over model geometry at a chosen time step. Also carries the server-resolved resolution hints (cadAssociations, topologyLabelByName) that postproc-manager populates and postproc-result-query consumes; these hints are stripped from the public API response, which uses the reduced StatisticsReportPropertiesPublic projection. At least one of partIdentifiers, partGroupIdentifiers, or cuttingPlanes must be provided.</summary>
public class StatisticsReportProperties : ReportProperties
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "STATISTICS";

    /// <summary>Names of individual model parts for which to compute statistics independently. Each name must exactly match a part na...</summary>
    [JsonPropertyName("partIdentifiers")]
    public List<string>? PartIdentifiers { get; set; }

    /// <summary>Named groups of parts whose bulk values are aggregated into a single combined result entry. Useful when several parts...</summary>
    [JsonPropertyName("partGroupIdentifiers")]
    public List<StatisticsPartGroup>? PartGroupIdentifiers { get; set; }

    /// <summary>Cutting planes for which to compute statistics. A cutting plane is an infinite plane defined by a point and a normal...</summary>
    [JsonPropertyName("cuttingPlanes")]
    public List<StatisticsCuttingPlane>? CuttingPlanes { get; set; }

    [JsonPropertyName("scalarField")]
    [JsonRequired]
    public required ScalarField ScalarField { get; set; }

    /// <summary>Zero-based time step index at which to evaluate the field. When not provided, statistics are computed at the last ava...</summary>
    [JsonPropertyName("frameIndex")]
    public int? FrameIndex { get; set; }

    /// <summary>Filtered CAD-Mesh name mapping for the requested parts only. Each key is a CAD entity name provided by the user and e...</summary>
    [JsonPropertyName("cadAssociations")]
    public Dictionary<string, List<string>>? CadAssociations { get; set; }

    /// <summary>Mesh-part-name to user-facing label mapping for the mesh topology, used to label cutting-plane regions with a human-r...</summary>
    [JsonPropertyName("topologyLabelByName")]
    public Dictionary<string, string>? TopologyLabelByName { get; set; }

}
