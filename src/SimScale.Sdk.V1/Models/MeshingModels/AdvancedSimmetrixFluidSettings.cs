using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AdvancedSimmetrixFluidSettings
{
    [JsonPropertyName("smallFeatureTolerance")]
    public Dimensional_Length? SmallFeatureTolerance { get; set; }

    /// <summary>Define a target number of elements across thin gaps. The Gap refinement factor is the ratio between gap thickness and...</summary>
    [JsonPropertyName("gapElements")]
    public double? GapElements { get; set; }

    /// <summary>Adjust the transition from small to large cells. This value is the ratio between the size of two adjacent cells. The...</summary>
    [JsonPropertyName("globalGradationRate")]
    public double? GlobalGradationRate { get; set; }

}
