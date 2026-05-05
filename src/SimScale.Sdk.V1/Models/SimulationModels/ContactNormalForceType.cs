using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ContactNormalForceType : OneOf_ContactFieldSelectionContactType
{
    /// <summary>Schema name: ContactNormalForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMAL_FORCE";

}
