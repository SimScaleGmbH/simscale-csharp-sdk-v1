using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidOnlyHeatTransfer : OneOf_DarcyForchheimerMediumPorousMediaHeatTransfer, OneOf_FixedCoeffMediumPorousMediaHeatTransfer, OneOf_PressureLossCurvePorousMediaHeatTransfer, OneOf_PerforatedPlatePorousMediaHeatTransfer, OneOf_PowerLawMediumPorousMediaHeatTransfer
{
    /// <summary>Schema name: FluidOnlyHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FLUID_ONLY_HEAT_TRANSFER";

}
