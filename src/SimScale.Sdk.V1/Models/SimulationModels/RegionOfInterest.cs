using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionOfInterest
{
    [JsonPropertyName("discRadius")]
    public Dimensional_Length? DiscRadius { get; set; }

    [JsonPropertyName("centerPoint")]
    public DimensionalVector2d_Length? CenterPoint { get; set; }

    [JsonPropertyName("groundHeight")]
    public Dimensional_Length? GroundHeight { get; set; }

    [JsonPropertyName("northAngle")]
    public Dimensional_Angle? NorthAngle { get; set; }

    [JsonPropertyName("advancedSettings")]
    public AdvancedROISettings? AdvancedSettings { get; set; }

}
