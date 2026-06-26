using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition sets the pressure based on the pressure drop specified as a function of the volumetric flow rate. Learn more</summary>
public class FanBC : OneOf_EmbeddedBoundaryBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_ConjugateHeatTransferBoundaryConditions
{
    /// <summary>This boundary condition sets the pressure based on the pressure drop specified as a function of the volumetric flow r...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FAN";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("pressure")]
    public FanPBC? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public OneOf_FanBCPressureRgh? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressure")]
    public FanPBC? GaugePressure { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public FanPBC? GaugePressureRgh { get; set; }

    [JsonPropertyName("turbulence")]
    public OneOf_FanBCTurbulence? Turbulence { get; set; }

    [JsonPropertyName("temperature")]
    public OneOf_FanBCTemperature? Temperature { get; set; }

    /// <summary>Please choose a boundary condition for passive scalar (T).</summary>
    [JsonPropertyName("passiveScalars")]
    public List<FixedValuePSBC>? PassiveScalars { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_FanBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_FanBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public FixedValueRHBC? RelativeHumidity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
