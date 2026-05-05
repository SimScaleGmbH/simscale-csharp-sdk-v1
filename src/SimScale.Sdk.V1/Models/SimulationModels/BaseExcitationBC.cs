using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Base excitation boundary condition applies a uniform acceleration to all fixed surfaces in the model (zero displacement), e.g. faces assigned to the Fixed support boundary condition. Specify the direction vector, the acceleration magnitude and the delay in terms of a harmonic phase angle, from the load to the reference harmonic excitation.Learn more</summary>
public class BaseExcitationBC : OneOf_HarmonicAnalysisBoundaryConditions
{
    /// <summary>Base excitation boundary condition applies a uniform acceleration to all fixed surfaces in the model (zero displaceme...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BASE_EXCITATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("direction")]
    public DimensionalVector_Dimensionless? Direction { get; set; }

    [JsonPropertyName("acceleration")]
    public DimensionalFunction_Acceleration? Acceleration { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

}
