using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GreybodyDiffusiveRSBC : OneOf_VelocityOutletBCNetRadiativeHeatFlux, OneOf_PressureInletBCNetRadiativeHeatFlux, OneOf_VelocityInletBCNetRadiativeHeatFlux, OneOf_FanBCNetRadiativeHeatFlux, OneOf_PressureOutletBCNetRadiativeHeatFlux, OneOf_NaturalConvectionInletOutletBCNetRadiativeHeatFlux, OneOf_WallBCNetRadiativeHeatFlux, OneOf_CustomFluidBCNetRadiativeHeatFlux
{
    /// <summary>Schema name: GreybodyDiffusiveRSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GREYBODY_DIFFUSIVE";

    [JsonPropertyName("emissivity")]
    public Dimensional_Dimensionless? Emissivity { get; set; }

}
