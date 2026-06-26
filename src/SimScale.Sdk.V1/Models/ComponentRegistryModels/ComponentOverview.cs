using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Read projection of a component, enriched with the display name taken from the latest non-archived version. Returned by endpoints that exist to display components (the listing endpoint and the single-component fetch); write/state-transition endpoints return `ComponentMetadata`.</summary>
public class ComponentOverview
{
    /// <summary>Reference to a component. Components are organized into a group hierarchy which serves as a qualification mechanism t...</summary>
    [JsonPropertyName("componentReference")]
    public string? ComponentReference { get; set; }

    [JsonPropertyName("componentType")]
    public string? ComponentType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Possible states of a component.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

}
