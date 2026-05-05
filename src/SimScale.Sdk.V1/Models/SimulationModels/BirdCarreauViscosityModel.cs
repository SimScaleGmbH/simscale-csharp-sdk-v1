using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class BirdCarreauViscosityModel : OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: BirdCarreauViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BIRD_CARREAU";

    [JsonPropertyName("nu0")]
    public Dimensional_KinematicViscosity? Nu0 { get; set; }

    [JsonPropertyName("nuInf")]
    public Dimensional_KinematicViscosity? NuInf { get; set; }

    [JsonPropertyName("k")]
    public Dimensional_Time? K { get; set; }

    [JsonPropertyName("n")]
    public Dimensional_Dimensionless? N { get; set; }

    [JsonPropertyName("a")]
    public Dimensional_Dimensionless? A { get; set; }

}
