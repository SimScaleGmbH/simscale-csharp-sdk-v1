using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The current in a single turn of the coil. For Stranded and Litz wire coils, the solver multiplies it by the Number of turns to obtain the ampere-turns.The current is shared over all entry (or internal) port faces of the coil, which are treated as parallel current paths. To model coils that are connected in series, create one coil per physical coil, each with a single port face, and assign the full current to every coil.</summary>
public class CurrentExcitation : OneOf_CoilExcitation
{
    /// <summary>The current in a single turn of the coil. For Stranded and Litz wire coils, the solver multiplies it by the Number of...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_EXCITATION";

    [JsonPropertyName("currentType")]
    public OneOf_CurrentExcitationCurrentType? CurrentType { get; set; }

    [JsonPropertyName("currentRMS")]
    public Dimensional_ElectricCurrent? CurrentRMS { get; set; }

    [JsonPropertyName("currentPhase")]
    public Dimensional_Angle? CurrentPhase { get; set; }

}
