using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EffectiveConductivityHeatTransfer : OneOf_PerforatedPlatePorousMediaHeatTransfer, OneOf_PressureLossCurvePorousMediaHeatTransfer, OneOf_FixedCoeffMediumPorousMediaHeatTransfer, OneOf_DarcyForchheimerMediumPorousMediaHeatTransfer, OneOf_PowerLawMediumPorousMediaHeatTransfer
{
    /// <summary>Schema name: EffectiveConductivityHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EFFECTIVE_CONDUCTIVITY_HEAT_TRANSFER";

    [JsonPropertyName("effectiveThermalConductivity")]
    public DimensionalFunction_ThermalConductivity? EffectiveThermalConductivity { get; set; }

}
