using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AllComputed : OneOf_MarcOutputWritingContainerOutputWriting
{
    /// <summary>Schema name: AllComputed</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ALL_COMPUTED";

}
