using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarlowHyperelasticModelMarc : OneOf_HyperelasticityHyperelasticModelMarc
{
    /// <summary>Schema name: MarlowHyperelasticModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MARLOW_MARC";

    /// <summary>Select the primary deformation mode from the experimental test data generation.Uniaxial (tension): Specifies that the...</summary>
    [JsonPropertyName("deformationMode")]
    public string? DeformationMode { get; set; }

    [JsonPropertyName("engineeringStressStrainCurve")]
    public DimensionalFunction_Pressure? EngineeringStressStrainCurve { get; set; }

    [JsonPropertyName("bulkModulus")]
    public Dimensional_Pressure? BulkModulus { get; set; }

}
