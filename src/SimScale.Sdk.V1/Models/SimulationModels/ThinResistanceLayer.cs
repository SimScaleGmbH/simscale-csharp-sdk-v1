using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the type of the contact resistance:To specify presence of thin layers with known thermal conductivity or/and electric resistivity and thickness, choose Thin layer resistance.If the thermal/electric contact resistance is known (e.g. due to an imperfectly matching interface, choose Contact resistance. The resistance can be defined as surface-dependent or not, i.e. total or specific. To make a resistance inactive, set it to 0. Enter a high value to make it an isolator.Conversely, if the thermal/electric contact conductance is known, choose Specific conductanceLearn more.</summary>
public class ThinResistanceLayer : OneOf_AdvancedConceptsThermalContactResistance
{
    /// <summary>Choose the type of the contact resistance:To specify presence of thin layers with known thermal conductivity or/and e...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THIN_RESISTANCE_LAYER";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("interfaceThermal")]
    public ContactInterfaceMaterialInterfaceThermal? InterfaceThermal { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
