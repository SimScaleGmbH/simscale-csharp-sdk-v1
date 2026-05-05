using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidElementTechnology
{
    [JsonPropertyName("elementTechnology3D")]
    public ElementTechnology? ElementTechnology3D { get; set; }

}
