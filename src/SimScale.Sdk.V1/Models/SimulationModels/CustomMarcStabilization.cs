using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomMarcStabilization : OneOf_AdvancedMarcNumericsSettingsMarcStabilization
{
    /// <summary>Schema name: CustomMarcStabilization</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    /// <summary>Target ratio of the energy dissipated by the damping to the strain energy of a load step (damping ratio of the artifi...</summary>
    [JsonPropertyName("energyDissipationRatio")]
    public double? EnergyDissipationRatio { get; set; }

}
