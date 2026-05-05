using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ContactStateType : OneOf_ContactFieldSelectionContactType
{
    /// <summary>Schema name: ContactStateType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATE";

}
