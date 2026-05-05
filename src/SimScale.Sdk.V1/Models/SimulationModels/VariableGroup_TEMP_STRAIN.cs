using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_TEMP_STRAIN
{
    [JsonPropertyName("E")]
    public Unit_Dimensionless? E { get; set; }

    [JsonPropertyName("Temperature")]
    public Unit_Temperature? Temperature { get; set; }

}
