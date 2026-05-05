using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The total current over all faces</summary>
public class CurrentExcitation : OneOf_CoilExcitation
{
    /// <summary>The total current over all faces Schema name: CurrentExcitation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_EXCITATION";

    [JsonPropertyName("currentType")]
    public OneOf_CurrentExcitationCurrentType? CurrentType { get; set; }

    [JsonPropertyName("currentRMS")]
    public Dimensional_ElectricCurrent? CurrentRMS { get; set; }

    [JsonPropertyName("currentPhase")]
    public Dimensional_Angle? CurrentPhase { get; set; }

}
