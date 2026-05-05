using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidResultControl
{
    /// <summary>Each mode is normalized using its largest component of displacement.</summary>
    [JsonPropertyName("solutionFields")]
    public List<OneOf_SolidResultControlSolutionFields>? SolutionFields { get; set; }

    [JsonPropertyName("edgeCalculation")]
    public List<OneOf_SolidResultControlEdgeCalculation>? EdgeCalculation { get; set; }

    [JsonPropertyName("areaCalculation")]
    public List<OneOf_SolidResultControlAreaCalculation>? AreaCalculation { get; set; }

    [JsonPropertyName("volumeCalculation")]
    public List<OneOf_SolidResultControlVolumeCalculation>? VolumeCalculation { get; set; }

    [JsonPropertyName("pointData")]
    public List<OneOf_SolidResultControlPointData>? PointData { get; set; }

}
