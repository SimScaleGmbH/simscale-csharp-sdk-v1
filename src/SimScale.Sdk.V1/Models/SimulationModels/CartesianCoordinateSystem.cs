using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Cartesian — Defines positions using three mutually perpendicular axes derived from an Origin, a first direction vector e1 (local x-axis), and a second direction vector e2 (local y-axis). The third axis (z) is computed automatically as the cross product of e1 and e2. Best suited for:Rectangular or box-shaped geometriesLinear motion or straight boundariesSetups where dimensions are naturally expressed as width, height, and depth</summary>
public class CartesianCoordinateSystem : OneOf_DynamicAnalysisLocalCoordinateSystems, OneOf_FrequencyAnalysisLocalCoordinateSystems, OneOf_StaticAnalysisLocalCoordinateSystems, OneOf_HeatTransferLocalCoordinateSystems, OneOf_ElectromagneticAnalysisLocalCoordinateSystems, OneOf_MarcAnalysisLocalCoordinateSystems, OneOf_ThermalMechanicalLocalCoordinateSystems, OneOf_HarmonicAnalysisLocalCoordinateSystems
{
    /// <summary>Cartesian — Defines positions using three mutually perpendicular axes derived from an Origin, a first direction vecto...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN_COORDINATE_SYSTEM";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("origin")]
    public DimensionalVector_Length? Origin { get; set; }

    [JsonPropertyName("e1")]
    public DimensionalVector_Dimensionless? E1 { get; set; }

    [JsonPropertyName("e2")]
    public DimensionalVector_Dimensionless? E2 { get; set; }

}
