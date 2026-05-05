using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticInitialConditions
{
    [JsonPropertyName("temperature")]
    public DimensionalInitialConditionDomains_Temperature? Temperature { get; set; }

}
