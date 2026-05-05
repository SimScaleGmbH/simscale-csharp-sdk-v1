using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GreybodyDiffusiveRSBC : OneOf_CustomFluidBCNetRadiativeHeatFlux, OneOf_VelocityOutletBCNetRadiativeHeatFlux, OneOf_VelocityInletBCNetRadiativeHeatFlux, OneOf_PressureInletBCNetRadiativeHeatFlux, OneOf_FanBCNetRadiativeHeatFlux, OneOf_WallBCNetRadiativeHeatFlux, OneOf_PressureOutletBCNetRadiativeHeatFlux, OneOf_NaturalConvectionInletOutletBCNetRadiativeHeatFlux
{
    /// <summary>Schema name: GreybodyDiffusiveRSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GREYBODY_DIFFUSIVE";

    [JsonPropertyName("emissivity")]
    public Dimensional_Dimensionless? Emissivity { get; set; }

}
