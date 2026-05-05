using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Radiative behaviour of the wall. The Kirchhoff's law of thermal radiation is applied in all options. This means that the absorptivity of the surface is equal to its emissivity. Opaque is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.Transparent is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.Semi-transparent is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.</summary>
public class SemiOpenBoundaryRayBC : OneOf_VelocityOutletBCRadiativeIntensityRay, OneOf_VelocityInletBCRadiativeIntensityRay, OneOf_PressureInletBCRadiativeIntensityRay, OneOf_FanBCRadiativeIntensityRay, OneOf_WallBCRadiativeIntensityRay, OneOf_PressureOutletBCRadiativeIntensityRay
{
    /// <summary>Radiative behaviour of the wall. The Kirchhoff's law of thermal radiation is applied in all options. This means that...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SEMI_OPEN_BOUNDARY_RAY";

    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

    [JsonPropertyName("transmissivity")]
    public double? Transmissivity { get; set; }

    [JsonPropertyName("farfieldBlackBodyTemperature")]
    public Dimensional_Temperature? FarfieldBlackBodyTemperature { get; set; }

}
