using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Configuration for a statistics (bulk calculation) report. Computes scalar field statistics (minimum, maximum, average, integral, and area/volume-weighted equivalents) over model geometry at a chosen time step. At least one of partIdentifiers, partGroupIdentifiers, or cuttingPlanes must be provided. Parts are named surfaces or volumes that exist in the simulation result (e.g. wall patches in a CFD model or solid bodies in a structural model). Use partIdentifiers to get independent results per part, or partGroupIdentifiers to combine several parts into one aggregated result. Cutting planes are user-defined infinite planes that slice through the model geometry. They are specified by a point on the plane and a normal vector, and statistics are computed over the intersection.</summary>
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

}
