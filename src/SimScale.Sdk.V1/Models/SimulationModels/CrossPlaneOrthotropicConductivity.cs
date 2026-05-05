using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CrossPlaneOrthotropicConductivity
{
    /// <summary>Schema name: CrossPlaneOrthotropicConductivity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CROSS_PLANE_ORTHOTROPIC";

    [JsonPropertyName("inPlaneConductivity")]
    public DimensionalFunction_ThermalConductivity? InPlaneConductivity { get; set; }

    [JsonPropertyName("crossPlaneConductivity")]
    public DimensionalFunction_ThermalConductivity? CrossPlaneConductivity { get; set; }

}
