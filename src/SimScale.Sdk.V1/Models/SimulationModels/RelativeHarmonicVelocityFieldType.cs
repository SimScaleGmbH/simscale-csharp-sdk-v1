using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeHarmonicVelocityFieldType : OneOf_VelocityFieldSelectionVelocityType
{
    /// <summary>Schema name: RelativeHarmonicVelocityFieldType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

}
