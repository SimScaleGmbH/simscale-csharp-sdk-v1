using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Partial filter settings applied as an override on top of the state's own filters. All properties are optional; only those provided are overridden.</summary>
public class FiltersOverride
{
    [JsonPropertyName("displacement")]
    public Displacement? Displacement { get; set; }

}
