using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConductivityThicknessPair
{
    [JsonPropertyName("thermalConductivity")]
    public Dimensional_ThermalConductivity? ThermalConductivity { get; set; }

    [JsonPropertyName("electricResistivity")]
    public Dimensional_ElectricResistivity? ElectricResistivity { get; set; }

    [JsonPropertyName("layerThickness")]
    public Dimensional_Length? LayerThickness { get; set; }

}
