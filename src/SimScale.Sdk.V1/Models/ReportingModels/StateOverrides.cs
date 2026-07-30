using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Render-time overrides applied on top of the fetched post-processor state, mirroring the report's own model/filter structure so each override is unambiguous. Additive - further sections (filters, ...) can be added over time without changing the report-from-state contract.</summary>
public class StateOverrides
{
    [JsonPropertyName("modelSettings")]
    public ModelSettingsOverride? ModelSettings { get; set; }

    [JsonPropertyName("filters")]
    public FiltersOverride? Filters { get; set; }

}
