using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VariableGroup_MAGNETIC_FIELD_STRENGTH
{
    [JsonPropertyName("H")]
    public Unit_MagneticFieldStrength? H { get; set; }

}
