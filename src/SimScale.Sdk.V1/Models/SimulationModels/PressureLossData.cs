using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureLossData
{
    [JsonPropertyName("pressureLossCurve")]
    public DimensionalFunction_Pressure? PressureLossCurve { get; set; }

    [JsonPropertyName("flowDirectionLength")]
    public Dimensional_Length? FlowDirectionLength { get; set; }

    [JsonPropertyName("crossSectionArea")]
    public Dimensional_Area? CrossSectionArea { get; set; }

}
