using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_PLASTIC_STRAIN
{
    [JsonPropertyName("E_PL")]
    public Unit_Dimensionless? EPl { get; set; }

}
