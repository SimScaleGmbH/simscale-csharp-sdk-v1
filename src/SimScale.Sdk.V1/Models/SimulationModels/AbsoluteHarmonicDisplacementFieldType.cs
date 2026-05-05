using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteHarmonicDisplacementFieldType : OneOf_DisplacementFieldSelectionDisplacementType
{
    /// <summary>Schema name: AbsoluteHarmonicDisplacementFieldType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

}
