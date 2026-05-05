using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class CrossPowerLawViscosityModel : OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: CrossPowerLawViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CROSS_POWER_LAW";

    [JsonPropertyName("nu0")]
    public Dimensional_KinematicViscosity? Nu0 { get; set; }

    [JsonPropertyName("nuInf")]
    public Dimensional_KinematicViscosity? NuInf { get; set; }

    [JsonPropertyName("m")]
    public Dimensional_Time? M { get; set; }

    [JsonPropertyName("n")]
    public Dimensional_Dimensionless? N { get; set; }

}
