using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MultilinearModelMarc : OneOf_PlasticityMarcPlasticityModel
{
    /// <summary>Schema name: MultilinearModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTILINEAR";

    [JsonPropertyName("stressStrainCurve")]
    public DimensionalFunction_Pressure? StressStrainCurve { get; set; }

    [JsonPropertyName("hardeningRule")]
    public OneOf_MultilinearModelMarcHardeningRule? HardeningRule { get; set; }

}
