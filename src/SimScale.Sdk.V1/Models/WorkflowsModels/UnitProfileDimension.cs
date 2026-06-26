using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>A profile of measurement units used for a particular dimension, containing a default unit and optionally additional units.</summary>
public class UnitProfileDimension
{
    [JsonPropertyName("additional")]
    public List<string>? Additional { get; set; }

    [JsonPropertyName("default")]
    public string? @Default { get; set; }

}
