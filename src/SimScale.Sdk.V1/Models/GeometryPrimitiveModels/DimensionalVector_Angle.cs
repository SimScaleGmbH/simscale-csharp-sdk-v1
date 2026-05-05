using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

public class DimensionalVector_Angle
{
    [JsonPropertyName("value")]
    public DecimalVector? Value { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
