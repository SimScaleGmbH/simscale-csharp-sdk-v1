using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GeographicalLocation
{
    [JsonPropertyName("latitude")]
    public Dimensional_Angle? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public Dimensional_Angle? Longitude { get; set; }

}
