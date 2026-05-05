using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PlasticityMarc
{
    [JsonPropertyName("plasticityModel")]
    public OneOf_PlasticityMarcPlasticityModel? PlasticityModel { get; set; }

}
