using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FairWeatherConditions : OneOf_SolarCalculatorSolarLoad
{
    /// <summary>Schema name: FairWeatherConditions</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FAIR_WEATHER_CONDITIONS";

    [JsonPropertyName("skyCloudCoverFraction")]
    public double? SkyCloudCoverFraction { get; set; }

    [JsonPropertyName("groundReflectivity")]
    public double? GroundReflectivity { get; set; }

    [JsonPropertyName("apparentSolarIrradiation")]
    public Dimensional_HeatFlux? ApparentSolarIrradiation { get; set; }

    /// <summary>Atmospheric extinction coefficient (B)</summary>
    [JsonPropertyName("atmosphericExtinctionCoefficient")]
    public double? AtmosphericExtinctionCoefficient { get; set; }

    /// <summary>Diffuse radiation factor (C)</summary>
    [JsonPropertyName("diffuseRadiationFactor")]
    public double? DiffuseRadiationFactor { get; set; }

}
