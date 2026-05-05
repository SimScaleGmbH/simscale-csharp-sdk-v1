using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticReferenceLength : OneOf_PacefishAutomeshReferenceLengthComputation
{
    /// <summary>Schema name: AutomaticReferenceLength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_REFERENCE_LENGTH";

}
