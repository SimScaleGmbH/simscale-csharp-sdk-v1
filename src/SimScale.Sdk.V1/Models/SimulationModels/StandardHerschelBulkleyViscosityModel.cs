using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between Newtonian and Non-Newtonian viscosity models.</summary>
public class StandardHerschelBulkleyViscosityModel : OneOf_IncompressibleMaterialViscosityModel
{
    /// <summary>Choose between Newtonian and Non-Newtonian viscosity models. Schema name: StandardHerschelBulkleyViscosityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STD_HERSCHEL_BULKLEY";

    [JsonPropertyName("consistency")]
    public Dimensional_DynamicViscosity? Consistency { get; set; }

    [JsonPropertyName("flowIndex")]
    public Dimensional_Dimensionless? FlowIndex { get; set; }

    [JsonPropertyName("fluidYieldStress")]
    public Dimensional_Pressure? FluidYieldStress { get; set; }

    [JsonPropertyName("criticalShearRate")]
    public Dimensional_StrainRate? CriticalShearRate { get; set; }

}
