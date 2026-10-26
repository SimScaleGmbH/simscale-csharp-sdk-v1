using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Per-element scope of a [ValidationRule]: the list whose elements are validated one by one, and the iterator reference through which the rule's cases address the element under evaluation (`iterator.relative("scale")` is the `scale` field of the current element).</summary>
public class ListElementScope
{
    /// <summary>Iterator reference for processing collections.</summary>
    [JsonPropertyName("iteratorReference")]
    public JsonElement? IteratorReference { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("list")]
    public JsonElement? List { get; set; }

}
