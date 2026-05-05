using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedComfortCriterionSettings
{
    /// <summary>Value of the gust factor kg used in the computation of the gust wind speed from the mean wind speed Umean and the sta...</summary>
    [JsonPropertyName("gustFactor")]
    public double? GustFactor { get; set; }

    /// <summary>Value of the gust equivalent mean correction factor kGEM used in the computation of the gust equivalent mean wind spe...</summary>
    [JsonPropertyName("gemCorrection")]
    public double? GemCorrection { get; set; }

}
