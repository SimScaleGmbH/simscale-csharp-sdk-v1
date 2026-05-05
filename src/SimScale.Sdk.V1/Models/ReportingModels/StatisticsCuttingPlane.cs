using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A cutting plane defined by a point and a normal vector. The plane is infinite and slices through the model geometry; statistics are computed over the resulting intersection.</summary>
public class StatisticsCuttingPlane
{
    /// <summary>Unique label for this cutting plane. Used as the key for this plane's entry in the statisticsResult map returned when...</summary>
    [JsonPropertyName("identifier")]
    [JsonRequired]
    public required string Identifier { get; set; }

    [JsonPropertyName("position")]
    [JsonRequired]
    public required Vector3D Position { get; set; }

    [JsonPropertyName("normal")]
    [JsonRequired]
    public required Vector3D Normal { get; set; }

}
