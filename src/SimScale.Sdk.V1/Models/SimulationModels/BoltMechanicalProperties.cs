using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BoltMechanicalProperties
{
    [JsonPropertyName("youngsModulus")]
    public Dimensional_Pressure? YoungsModulus { get; set; }

    /// <summary>Provide the Poisson's ratio value which describes the compression or elongation of the bolt material transverse to ax...</summary>
    [JsonPropertyName("poissonsRatio")]
    public double? PoissonsRatio { get; set; }

    [JsonPropertyName("density")]
    public Dimensional_Density? Density { get; set; }

}
