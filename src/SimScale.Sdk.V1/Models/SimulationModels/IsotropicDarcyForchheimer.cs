using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Isotropic porous object where the same permeability and friction form coefficient are applied in all directions.</summary>
public class IsotropicDarcyForchheimer : OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType, OneOf_DirectionalDependencyDarcyForchheimerType
{
    /// <summary>Isotropic porous object where the same permeability and friction form coefficient are applied in all directions. Sche...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

}
