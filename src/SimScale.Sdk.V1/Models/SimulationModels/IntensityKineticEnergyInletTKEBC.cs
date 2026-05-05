using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IntensityKineticEnergyInletTKEBC : OneOf_CustomFluidBCTurbulentKineticEnergy
{
    /// <summary>Schema name: IntensityKineticEnergyInletTKEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENT_INTENSITY_KINETIC_ENERGY_INLET";

    [JsonPropertyName("intensity")]
    public double? Intensity { get; set; }

}
