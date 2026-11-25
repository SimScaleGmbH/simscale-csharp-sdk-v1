using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Cylindrical — Defines positions using an Origin, a Polar direction vector (radial reference axis) and an Axial direction vector (z-axis). Positions are expressed as a radial distance (r), an angle (Φ) measured from the polar axis, and a height (z) along the axial axis. Best suited for:Rotationally symmetric or tubular geometriesRotating machinery, pipes, or circular boundariesSetups where distances from a central axis are of primary interest</summary>
public class CylindricalCoordinateSystem : OneOf_DynamicAnalysisLocalCoordinateSystems, OneOf_FrequencyAnalysisLocalCoordinateSystems, OneOf_StaticAnalysisLocalCoordinateSystems, OneOf_HeatTransferLocalCoordinateSystems, OneOf_ElectromagneticAnalysisLocalCoordinateSystems, OneOf_MarcAnalysisLocalCoordinateSystems, OneOf_ThermalMechanicalLocalCoordinateSystems, OneOf_HarmonicAnalysisLocalCoordinateSystems
{
    /// <summary>Cylindrical — Defines positions using an Origin, a Polar direction vector (radial reference axis) and an Axial direct...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CYLINDRICAL_COORDINATE_SYSTEM";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("origin")]
    public DimensionalVector_Length? Origin { get; set; }

    [JsonPropertyName("polar")]
    public DimensionalVector_Dimensionless? Polar { get; set; }

    [JsonPropertyName("axial")]
    public DimensionalVector_Dimensionless? Axial { get; set; }

}
