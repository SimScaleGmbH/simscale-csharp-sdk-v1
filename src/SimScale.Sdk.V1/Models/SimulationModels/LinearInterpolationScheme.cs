using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LinearInterpolationScheme : OneOf_InterpolationSchemesForDefault, OneOf_InterpolationSchemesInterpolate_HbyA, OneOf_InterpolationSchemesInterpolate_velocity, OneOf_InterpolationSchemesInterpolate_kappa, OneOf_InterpolationSchemesInterpolate_rho, OneOf_InterpolationSchemesInterpolate_thermo_rho_Cp, OneOf_InterpolationSchemesInterpolate_map_Kappa, OneOf_InterpolationSchemesInterpolate_rho_Hbya, OneOf_InterpolationSchemesInterpolate_rho_0_velocity0, OneOf_InterpolationSchemesInterpolate_grad_enthalpy, OneOf_InterpolationSchemesInterpolate_rho_rAU, OneOf_InterpolationSchemesInterpolate_rAU, OneOf_InterpolationSchemesInterpolate_velocity0, OneOf_InterpolationSchemesReconstruct_velocity, OneOf_InterpolationSchemesReconstruct_temperature, OneOf_InterpolationSchemesReconstruct_rho
{
    /// <summary>Schema name: LinearInterpolationScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LINEAR";

}
