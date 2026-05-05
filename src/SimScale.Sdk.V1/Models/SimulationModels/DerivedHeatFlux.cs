using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DerivedHeatFlux : OneOf_ExternalWallHeatFluxTBCHeatFlux
{
    /// <summary>Schema name: DerivedHeatFlux</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DERIVED";

    [JsonPropertyName("heatTransferCoefficient")]
    public Dimensional_ThermalTransmittance? HeatTransferCoefficient { get; set; }

    [JsonPropertyName("ambientTemperature")]
    public Dimensional_Temperature? AmbientTemperature { get; set; }

    [JsonPropertyName("additionalHeatFlux")]
    public Dimensional_HeatFlux? AdditionalHeatFlux { get; set; }

    [JsonPropertyName("wallThermal")]
    public OneOf_DerivedHeatFluxWallThermal? WallThermal { get; set; }

    /// <summary>Emissivity/Absorptivity of the outer side of the surface or the last wall thermal layer.</summary>
    [JsonPropertyName("outerSurfaceEmissivity")]
    public double? OuterSurfaceEmissivity { get; set; }

}
