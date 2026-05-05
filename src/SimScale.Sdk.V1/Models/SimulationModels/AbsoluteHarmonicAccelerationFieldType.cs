using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteHarmonicAccelerationFieldType : OneOf_AccelerationFieldSelectionAccelerationType
{
    /// <summary>Schema name: AbsoluteHarmonicAccelerationFieldType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

}
