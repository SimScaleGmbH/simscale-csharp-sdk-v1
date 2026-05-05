using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Directional porous object where the permeability and friction form coefficient are applied only in the specified direction. For directions orthogonal to the specified direction, the permeability is set to zero, i.e. there is no flow in the orthogonal directions.</summary>
public class RectifyingDarcyForchheimer : OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType, OneOf_DirectionalDependencyDarcyForchheimerType
{
    /// <summary>Directional porous object where the permeability and friction form coefficient are applied only in the specified dire...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RECTIFYING";

    [JsonPropertyName("direction")]
    public DimensionalVector_Length? Direction { get; set; }

}
