using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class HerschelBulkleyViscosityModel : OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: HerschelBulkleyViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HERSCHEL_BULKLEY";

    [JsonPropertyName("k")]
    public Dimensional_KinematicViscosity? K { get; set; }

    [JsonPropertyName("n")]
    public Dimensional_Dimensionless? N { get; set; }

    [JsonPropertyName("tau0")]
    public Dimensional_TurbulenceKineticEnergy? Tau0 { get; set; }

    [JsonPropertyName("nu0")]
    public Dimensional_KinematicViscosity? Nu0 { get; set; }

}
