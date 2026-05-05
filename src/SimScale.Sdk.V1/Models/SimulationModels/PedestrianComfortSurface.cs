using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PedestrianComfortSurface
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heightAboveGround")]
    public Dimensional_Length? HeightAboveGround { get; set; }

    [JsonPropertyName("ground")]
    public OneOf_PedestrianComfortSurfaceGround? Ground { get; set; }

}
