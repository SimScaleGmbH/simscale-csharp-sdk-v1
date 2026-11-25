using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BoltMechanicalProperties
{
    [JsonPropertyName("youngsModulus")]
    public Dimensional_Pressure? YoungsModulus { get; set; }

    /// <summary>Poisson's ratio of the bolt material. It must be greater than -1 and less than 0.5.</summary>
    [JsonPropertyName("poissonsRatio")]
    public double? PoissonsRatio { get; set; }

    [JsonPropertyName("density")]
    public Dimensional_Density? Density { get; set; }

}
