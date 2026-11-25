using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcThermalProperties
{
    [JsonPropertyName("conductivity")]
    public OneOf_MarcThermalPropertiesConductivity? Conductivity { get; set; }

    [JsonPropertyName("specificHeat")]
    public DimensionalFunction_SpecificHeat? SpecificHeat { get; set; }

}
