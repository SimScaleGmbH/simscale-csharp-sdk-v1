using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindComfortSimulationControl
{
    [JsonPropertyName("maxDirectionRunTime")]
    public Dimensional_Time? MaxDirectionRunTime { get; set; }

    /// <summary>Set how many times the fluid (air) passes over the domain during the simulation. Warning: Values below 2.0 might prod...</summary>
    [JsonPropertyName("numberOfFluidPasses")]
    public double? NumberOfFluidPasses { get; set; }

    /// <summary>It affects the stability of the simulation. The default value of 0.1 is a good compromise between accuracy and comput...</summary>
    [JsonPropertyName("velocityScaling")]
    public double? VelocityScaling { get; set; }

}
