using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcInitialConditions
{
    [JsonPropertyName("temperature")]
    public DimensionalFunctionInitialConditionDomains_Temperature? Temperature { get; set; }

}
