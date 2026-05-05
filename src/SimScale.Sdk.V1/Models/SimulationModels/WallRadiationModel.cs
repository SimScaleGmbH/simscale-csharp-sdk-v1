using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallRadiationModel
{
    /// <summary>The proportionality factor emissivity defines the type of radiation. The lower bound (0) determining complete reflect...</summary>
    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

    [JsonPropertyName("ambientTemperature")]
    public Dimensional_Temperature? AmbientTemperature { get; set; }

}
