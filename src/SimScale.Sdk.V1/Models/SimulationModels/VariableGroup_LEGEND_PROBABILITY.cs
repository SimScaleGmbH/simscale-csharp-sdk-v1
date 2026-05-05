using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_LEGEND_PROBABILITY
{
    [JsonPropertyName("Legend")]
    public Unit_Text? Legend { get; set; }

    [JsonPropertyName("Probability [%]")]
    public Unit_Dimensionless? Probability { get; set; }

}
