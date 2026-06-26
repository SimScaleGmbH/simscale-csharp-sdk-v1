using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Description of the input and output data of a method or a workflow.</summary>
public class DataInterface
{
    [JsonPropertyName("input")]
    public List<DataDescription>? Input { get; set; }

    [JsonPropertyName("output")]
    public List<DataDescription>? Output { get; set; }

}
