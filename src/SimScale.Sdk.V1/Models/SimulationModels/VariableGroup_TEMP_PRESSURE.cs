using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_TEMP_PRESSURE
{
    [JsonPropertyName("Temperature")]
    public Unit_Temperature? Temperature { get; set; }

    [JsonPropertyName("Pressure")]
    public Unit_Pressure? Pressure { get; set; }

}
