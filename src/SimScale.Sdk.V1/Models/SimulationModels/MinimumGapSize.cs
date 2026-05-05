using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MinimumGapSize : OneOf_PacefishAutomeshAutomaticGapClosing, OneOf_WindComfortMeshAutomaticGapClosing
{
    /// <summary>Schema name: MinimumGapSize</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MINIMUM_GAP_SIZE";

    [JsonPropertyName("minimumGapSize")]
    public Dimensional_Length? MinimumGapSizeValue { get; set; }

}
