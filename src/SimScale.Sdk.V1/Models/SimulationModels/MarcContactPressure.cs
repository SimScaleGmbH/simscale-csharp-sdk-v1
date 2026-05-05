using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactPressure : OneOf_MarcContactResultControlItemContactType
{
    /// <summary>Schema name: MarcContactPressure</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

}
