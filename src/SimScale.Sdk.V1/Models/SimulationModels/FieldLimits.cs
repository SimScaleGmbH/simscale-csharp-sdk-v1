using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldLimits
{
    [JsonPropertyName("lowerDensityBound")]
    public Dimensional_Density? LowerDensityBound { get; set; }

    [JsonPropertyName("upperDensityBound")]
    public Dimensional_Density? UpperDensityBound { get; set; }

    [JsonPropertyName("lowerPressureBound")]
    public Dimensional_Pressure? LowerPressureBound { get; set; }

    [JsonPropertyName("upperPressureBound")]
    public Dimensional_Pressure? UpperPressureBound { get; set; }

    [JsonPropertyName("lowerTemperatureBound")]
    public Dimensional_Temperature? LowerTemperatureBound { get; set; }

    [JsonPropertyName("upperTemperatureBound")]
    public Dimensional_Temperature? UpperTemperatureBound { get; set; }

}
