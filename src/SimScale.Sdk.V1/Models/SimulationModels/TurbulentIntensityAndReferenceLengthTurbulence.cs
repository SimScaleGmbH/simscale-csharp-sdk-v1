using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TurbulentIntensityAndReferenceLengthTurbulence : OneOf_NaturalConvectionInletOutletBCTurbulence, OneOf_FanBCTurbulence, OneOf_PressureInletBCTurbulence, OneOf_VelocityInletBCTurbulence
{
    /// <summary>Schema name: TurbulentIntensityAndReferenceLengthTurbulence</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TURBULENT_INTENSITY_AND_REFERENCE_LENGTH_TURBULENCE";

    /// <summary>This provides a turbulent intensity boundary condition. The turbulent intensity is defined as the ratio of the root-m...</summary>
    [JsonPropertyName("turbulentIntensity")]
    public double? TurbulentIntensity { get; set; }

    [JsonPropertyName("mixingLength")]
    public Dimensional_Length? MixingLength { get; set; }

}
