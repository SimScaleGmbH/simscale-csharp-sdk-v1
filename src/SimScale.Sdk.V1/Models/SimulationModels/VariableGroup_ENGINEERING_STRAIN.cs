using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_ENGINEERING_STRAIN
{
    [JsonPropertyName("E_ENG")]
    public Unit_Dimensionless? EEng { get; set; }

}
