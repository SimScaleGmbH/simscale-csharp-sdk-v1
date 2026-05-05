using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OutputSteps : OneOf_MarcOutputWritingContainerOutputWriting
{
    /// <summary>Schema name: OutputSteps</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTPUT_STEPS";

    /// <summary>Specify the number of output steps for the entire simulation. They are distributed as evenly as possible.</summary>
    [JsonPropertyName("numberOfOutputSteps")]
    public int? NumberOfOutputSteps { get; set; }

}
