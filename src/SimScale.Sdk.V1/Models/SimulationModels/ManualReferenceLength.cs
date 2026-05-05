using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualReferenceLength : OneOf_PacefishAutomeshReferenceLengthComputation
{
    /// <summary>Schema name: ManualReferenceLength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_REFERENCE_LENGTH";

    [JsonPropertyName("value")]
    public Dimensional_Length? Value { get; set; }

}
