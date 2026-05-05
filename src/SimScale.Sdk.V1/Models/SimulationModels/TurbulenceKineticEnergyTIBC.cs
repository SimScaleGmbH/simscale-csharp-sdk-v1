using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TurbulenceKineticEnergyTIBC : OneOf_VelocityInletBCTurbulenceIntensity
{
    /// <summary>Schema name: TurbulenceKineticEnergyTIBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENCE_KINETIC_ENERGY";

    [JsonPropertyName("value")]
    public DimensionalFunction_TurbulenceKineticEnergy? Value { get; set; }

}
