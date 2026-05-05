using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class SimulationRunResultPlot : OneOfSimulationRunResult
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PLOT";

    /// <summary>The result ID</summary>
    [JsonPropertyName("resultId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ResultId { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("direction")]
    public double? Direction { get; set; }

    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time when the result was last modified.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTimeOffset? ModifiedAt { get; set; }

    /// <summary>URL for opening the plot in the Workbench.</summary>
    [JsonPropertyName("workbenchUrl")]
    public string? WorkbenchUrl { get; set; }

    /// <summary>Supported export format for this result.</summary>
    [JsonPropertyName("availableExportFormats")]
    public List<string>? AvailableExportFormats { get; set; }

}
