using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Hyperelasticity
{
    [JsonPropertyName("hyperelasticModelMarc")]
    public OneOf_HyperelasticityHyperelasticModelMarc? HyperelasticModelMarc { get; set; }

}
