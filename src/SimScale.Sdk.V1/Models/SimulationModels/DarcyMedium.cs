using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DarcyMedium : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: DarcyMedium</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DARCY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Porosity is the fraction of a volume of material is that is void. It ranges from φ = 1 (completely empty) to φ = 0 (c...</summary>
    [JsonPropertyName("porosity")]
    public double? Porosity { get; set; }

    [JsonPropertyName("permeability")]
    public Dimensional_Area? Permeability { get; set; }

    /// <summary>The Darcy law may be extended to include the Forchheimer drag term for more inertial flows (Re &gt; 10). This term is...</summary>
    [JsonPropertyName("dragCoefficient")]
    public double? DragCoefficient { get; set; }

    [JsonPropertyName("porousMaterialType")]
    public OneOf_DarcyMediumPorousMaterialType? PorousMaterialType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
