using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>A dimensional vector is represented by a 3D vector and a unit. By convention, all operators return a DimensionalVector in base SI units. The interface for certain functions accepts Numbers instead of Doubles so that we can have operations with all types of numbers. If this proves to be a performance bottleneck, we can re-assess.</summary>
public class DimensionalVectorObject
{
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("vector")]
    public Vector? Vector { get; set; }

}
