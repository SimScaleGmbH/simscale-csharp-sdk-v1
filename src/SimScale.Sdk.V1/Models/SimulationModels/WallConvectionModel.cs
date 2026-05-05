using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallConvectionModel
{
    [JsonPropertyName("convectionCoefficient")]
    public Dimensional_ThermalTransmittance? ConvectionCoefficient { get; set; }

    [JsonPropertyName("ambientTemperature")]
    public Dimensional_Temperature? AmbientTemperature { get; set; }

}
