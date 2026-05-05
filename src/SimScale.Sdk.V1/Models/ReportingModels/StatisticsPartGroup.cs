using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A named group of model parts whose bulk values are aggregated into a single result entry. All parts in the group are combined before computing statistics, so the result reflects the collective geometry rather than individual parts.</summary>
public class StatisticsPartGroup
{
    /// <summary>Unique label for this group. Used as the key for this group's entry in the statisticsResult map returned when the rep...</summary>
    [JsonPropertyName("identifier")]
    [JsonRequired]
    public required string Identifier { get; set; }

    /// <summary>Names of the model parts to include in this group. Each name must exactly match a part name present in the simulation...</summary>
    [JsonPropertyName("partNames")]
    [JsonRequired]
    public required List<string> PartNames { get; set; }

}
