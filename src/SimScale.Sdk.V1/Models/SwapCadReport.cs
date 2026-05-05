using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>The report provides details on unsuccessful entity mappings found in the assignments. Ideally, this section should be empty, indicating that all entities were mapped correctly. Please review the reported fields to verify and correct any discrepancies.</summary>
public class SwapCadReport
{
    /// <summary>List of unmapped assignments.</summary>
    [JsonPropertyName("unmappedPaths")]
    public List<string>? UnmappedPaths { get; set; }

    /// <summary>List of partially mapped assignments.</summary>
    [JsonPropertyName("partiallyMappedPaths")]
    public List<string>? PartiallyMappedPaths { get; set; }

}
