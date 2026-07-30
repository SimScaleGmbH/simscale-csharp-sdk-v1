using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A single located extreme (the minimum or the maximum) with its value, coordinates, part, and step. Whether the value is node- or cell-based is given by the result's dataType.</summary>
public class GlobalMinMaxExtreme
{
    [JsonPropertyName("value")]
    public MeasuredScalar? Value { get; set; }

    [JsonPropertyName("coordinates")]
    public MeasuredVector? Coordinates { get; set; }

    /// <summary>The mesh part name the extreme was found on; null if the part could not be resolved.</summary>
    [JsonPropertyName("partName")]
    public string? PartName { get; set; }

    /// <summary>The user-facing label of that part (resolved from the mesh topology); null when no label is available or the part cou...</summary>
    [JsonPropertyName("partLabel")]
    public string? PartLabel { get; set; }

    /// <summary>The step at which this extreme occurred (a time-step for transient analyses, a frequency for harmonic, etc).</summary>
    [JsonPropertyName("step")]
    public JsonElement? Step { get; set; }

}
