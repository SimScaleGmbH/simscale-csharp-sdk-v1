using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EffectiveConductivityHeatTransfer : OneOf_FixedCoeffMediumPorousMediaHeatTransfer, OneOf_PowerLawMediumPorousMediaHeatTransfer, OneOf_PerforatedPlatePorousMediaHeatTransfer, OneOf_PressureLossCurvePorousMediaHeatTransfer, OneOf_DarcyForchheimerMediumPorousMediaHeatTransfer
{
    /// <summary>Schema name: EffectiveConductivityHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EFFECTIVE_CONDUCTIVITY_HEAT_TRANSFER";

    [JsonPropertyName("effectiveThermalConductivity")]
    public DimensionalFunction_ThermalConductivity? EffectiveThermalConductivity { get; set; }

}
