using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedMarcNumericsSettings
{
    [JsonPropertyName("marcStabilization")]
    public OneOf_AdvancedMarcNumericsSettingsMarcStabilization? MarcStabilization { get; set; }

}
