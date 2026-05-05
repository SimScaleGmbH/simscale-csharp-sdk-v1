using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InterpolationSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_InterpolationSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("interpolate_HbyA")]
    public OneOf_InterpolationSchemesInterpolate_HbyA? InterpolateHbya { get; set; }

    [JsonPropertyName("interpolate_velocity")]
    public OneOf_InterpolationSchemesInterpolate_velocity? InterpolateVelocity { get; set; }

    [JsonPropertyName("interpolate_kappa")]
    public OneOf_InterpolationSchemesInterpolate_kappa? InterpolateKappa { get; set; }

    [JsonPropertyName("interpolate_rho")]
    public OneOf_InterpolationSchemesInterpolate_rho? InterpolateRho { get; set; }

    [JsonPropertyName("interpolate_thermo_rho_Cp")]
    public OneOf_InterpolationSchemesInterpolate_thermo_rho_Cp? InterpolateThermoRhoCp { get; set; }

    [JsonPropertyName("interpolate_map_Kappa")]
    public OneOf_InterpolationSchemesInterpolate_map_Kappa? InterpolateMapKappa { get; set; }

    [JsonPropertyName("interpolate_rho_Hbya")]
    public OneOf_InterpolationSchemesInterpolate_rho_Hbya? InterpolateRhoHbya { get; set; }

    [JsonPropertyName("interpolate_rho_0_velocity0")]
    public OneOf_InterpolationSchemesInterpolate_rho_0_velocity0? InterpolateRho0Velocity0 { get; set; }

    [JsonPropertyName("interpolate_grad_enthalpy")]
    public OneOf_InterpolationSchemesInterpolate_grad_enthalpy? InterpolateGradEnthalpy { get; set; }

    [JsonPropertyName("interpolate_rho_rAU")]
    public OneOf_InterpolationSchemesInterpolate_rho_rAU? InterpolateRhoRau { get; set; }

    [JsonPropertyName("interpolate_rAU")]
    public OneOf_InterpolationSchemesInterpolate_rAU? InterpolateRau { get; set; }

    [JsonPropertyName("interpolate_velocity0")]
    public OneOf_InterpolationSchemesInterpolate_velocity0? InterpolateVelocity0 { get; set; }

    [JsonPropertyName("reconstruct_velocity")]
    public OneOf_InterpolationSchemesReconstruct_velocity? ReconstructVelocity { get; set; }

    [JsonPropertyName("reconstruct_temperature")]
    public OneOf_InterpolationSchemesReconstruct_temperature? ReconstructTemperature { get; set; }

    [JsonPropertyName("reconstruct_rho")]
    public OneOf_InterpolationSchemesReconstruct_rho? ReconstructRho { get; set; }

}
