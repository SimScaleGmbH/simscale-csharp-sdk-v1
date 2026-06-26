using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_TEMP_PLASTIC_STRAIN
{
    [JsonPropertyName("E_PL")]
    public Unit_Dimensionless? EPl { get; set; }

    [JsonPropertyName("Temperature")]
    public Unit_Temperature? Temperature { get; set; }

}
