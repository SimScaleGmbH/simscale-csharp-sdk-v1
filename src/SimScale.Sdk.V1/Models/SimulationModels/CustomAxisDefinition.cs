using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomAxisDefinition : OneOf_HingeConstraintBCAxisDefinition
{
    /// <summary>Schema name: CustomAxisDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("axisOrigin")]
    public DimensionalVector_Length? AxisOrigin { get; set; }

    [JsonPropertyName("axisDirection")]
    public DimensionalVector_Dimensionless? AxisDirection { get; set; }

}
