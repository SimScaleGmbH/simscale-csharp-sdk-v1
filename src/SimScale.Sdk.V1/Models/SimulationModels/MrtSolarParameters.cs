using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MrtSolarParameters
{
    [JsonPropertyName("fractionBodySurface")]
    public OneOf_MrtSolarParametersFractionBodySurface? FractionBodySurface { get; set; }

    /// <summary>The projected area of a standard person exposed to direct beam sunlight in the range [0, 1]. This projection depends...</summary>
    [JsonPropertyName("projectedAreaFactor")]
    public double? ProjectedAreaFactor { get; set; }

    /// <summary>The radiation wavelength of a source depends on its temperature. Since the sun is much hotter than surfaces in a typi...</summary>
    [JsonPropertyName("shortWaveAbsorptivity")]
    public double? ShortWaveAbsorptivity { get; set; }

}
