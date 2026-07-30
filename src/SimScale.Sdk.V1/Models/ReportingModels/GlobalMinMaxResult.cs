using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>The global minimum and maximum of a scalar field across the entire model over the selected steps.</summary>
public class GlobalMinMaxResult
{
    /// <summary>The label of the scalar field whose global minimum and maximum are reported here.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("minimum")]
    public GlobalMinMaxExtreme? Minimum { get; set; }

    [JsonPropertyName("maximum")]
    public GlobalMinMaxExtreme? Maximum { get; set; }

}
