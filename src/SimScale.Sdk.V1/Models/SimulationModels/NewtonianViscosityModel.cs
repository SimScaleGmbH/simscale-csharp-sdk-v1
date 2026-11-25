using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class NewtonianViscosityModel : OneOf_FluidCompressibleMaterialViscosityModel, OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: NewtonianViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWTONIAN";

    [JsonPropertyName("kinematicViscosity")]
    public Dimensional_KinematicViscosity? KinematicViscosity { get; set; }

    [JsonPropertyName("kinematicViscosityFunction")]
    public DimensionalFunction_KinematicViscosity? KinematicViscosityFunction { get; set; }

    [JsonPropertyName("dynamicViscosityFunction")]
    public DimensionalFunction_DynamicViscosity? DynamicViscosityFunction { get; set; }

}
