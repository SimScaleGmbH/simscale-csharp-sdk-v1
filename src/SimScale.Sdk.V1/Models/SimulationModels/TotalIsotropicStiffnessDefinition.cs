using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalIsotropicStiffnessDefinition : OneOf_IsotropicSpringStiffnessStiffnessDefinition
{
    /// <summary>Schema name: TotalIsotropicStiffnessDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_ISOTROPIC";

    [JsonPropertyName("total")]
    public Dimensional_SurfaceTension? Total { get; set; }

}
