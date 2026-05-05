using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureLossFunctionMedium : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: PressureLossFunctionMedium</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_LOSS_FUNCTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressureLossFunction")]
    public DimensionalFunction_Pressure? PressureLossFunction { get; set; }

    [JsonPropertyName("porousMaterialType")]
    public OneOf_PressureLossFunctionMediumPorousMaterialType? PorousMaterialType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
