using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Axis of rotation.</summary>
public class Axis
{
    [JsonPropertyName("value")]
    public Vector? Value { get; set; }

}
