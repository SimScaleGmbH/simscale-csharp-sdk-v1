using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallContactAngle
{
    [JsonPropertyName("enableWallContactAngle")]
    public bool? EnableWallContactAngle { get; set; }

    [JsonPropertyName("associatedPhase")]
    public string? AssociatedPhase { get; set; }

    [JsonPropertyName("contactAngle")]
    public Dimensional_Angle? ContactAngle { get; set; }

}
