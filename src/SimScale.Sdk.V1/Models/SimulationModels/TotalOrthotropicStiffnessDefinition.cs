using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalOrthotropicStiffnessDefinition : OneOf_OrthotropicSpringStiffnessStiffnessDefinition
{
    /// <summary>Schema name: TotalOrthotropicStiffnessDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_ORTHOTROPIC";

    [JsonPropertyName("total")]
    public DimensionalVector_SurfaceTension? Total { get; set; }

}
