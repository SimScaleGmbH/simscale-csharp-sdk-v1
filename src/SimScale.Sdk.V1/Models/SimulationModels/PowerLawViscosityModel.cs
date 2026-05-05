using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class PowerLawViscosityModel : OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: PowerLawViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POWER_LAW";

    [JsonPropertyName("k")]
    public Dimensional_KinematicViscosity? K { get; set; }

    [JsonPropertyName("n")]
    public Dimensional_Dimensionless? N { get; set; }

    [JsonPropertyName("nuMin")]
    public Dimensional_KinematicViscosity? NuMin { get; set; }

    [JsonPropertyName("nuMax")]
    public Dimensional_KinematicViscosity? NuMax { get; set; }

}
