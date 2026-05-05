using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PowerFerriteCoreLoss : OneOf_ElectromagneticMaterialCoreLossesType
{
    /// <summary>Schema name: PowerFerriteCoreLoss</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POWER_FERRITE";

    [JsonPropertyName("steinmetzConstant")]
    public double? SteinmetzConstant { get; set; }

    [JsonPropertyName("frequencyExponent")]
    public double? FrequencyExponent { get; set; }

    [JsonPropertyName("fluxDensityExponent")]
    public double? FluxDensityExponent { get; set; }

}
