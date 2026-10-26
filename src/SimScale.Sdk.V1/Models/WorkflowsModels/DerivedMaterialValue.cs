using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>A value derived while materializing a material slot, written at a path within the effective material.</summary>
public class DerivedMaterialValue
{
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("value")]
    public Value? Value { get; set; }

}
