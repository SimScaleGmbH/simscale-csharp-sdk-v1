using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcOutputWritingContainer
{
    [JsonPropertyName("outputWriting")]
    public OneOf_MarcOutputWritingContainerOutputWriting? OutputWriting { get; set; }

}
